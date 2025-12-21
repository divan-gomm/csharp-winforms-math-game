using MysticMathsGame__Divan_Gomm.Classes;
using MysticMathsGame__Divan_Gomm.Enums;
using MysticMathsGame__Divan_Gomm.Interface;
using MysticMathsGame__Divan_Gomm.Top_Scores;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Author: Divan Gomm
Date: 2025/08/28
Purose:
This is the Main form of Mystic Math Game.
It handles the game UI, player input, battle logic, attack button, HP updates, battle log and the ScoreManager.
*/

namespace MysticMathsGame__Divan_Gomm
{
    public partial class Form1 : Form
    {
        #region Fields
        private Player hero;
        private Enemy enemy;

        //Attacks
        private Attack basicStrike;
        private Attack primeStrike;
        private Attack modulusStrike;

        private Random rand = new Random();


        //ScoreManager
        ScoreManager scoreManager = new ScoreManager();
        string scoreFile = "scoreboard.txt";



        #endregion


        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Form 1 Load
        private void Form1_Load(object sender, EventArgs e)
        {
            //Try Catch block for scoreboard file load exception
            try
            {
                if (!File.Exists(scoreFile))
                File.Create(scoreFile).Close();

                scoreManager.LoadScores(scoreFile);
                scoreManager.DisplayScores(lbScores);

            }
            catch (IOException ex) 
            {
                MessageBox.Show($"Error loading scoreboard: {ex.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Disable Start button until confirm is clicked 
            btnStart.Enabled = false;

            //Disable Attack buttons
            btnBasicStrike.Enabled = false;
            btnPrimeStrike.Enabled = false;
            btnModulusStrike.Enabled = false;

        }
        #endregion


        #region Enter Player Name and Validate (Confirm Button)
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;

            //REGEX verification on player name

            if (!System.Text.RegularExpressions.Regex.IsMatch(playerName, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Invalid name! Use letters only.");
                return;
            }

            //Create a new Player
            hero = new Player(playerName, 100);

            //Messagebox welcome message
            MessageBox.Show($"Name verified, click OK to continue.", "information" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Welcome new Player
            lblMessage.Text = $"Welcome {hero.Name}! Click Start to Begin";
            lblMessage.AutoSize = true;
            lblMessage.Left = (this.ClientSize.Width - lblMessage.Width) / 2;

            //Disable input after confirm
            txtPlayerName.Enabled = false;
            btnConfirm.Enabled = false;

            //Enable Start button
            btnStart.Enabled = true;


        }

        #endregion


        #region Start Button - Create enemy and attacks
        
        
        private void btnStart_Click(object sender, EventArgs e)
        {   //Try catch for no name entered
            try
            {
                hero.HP = 100;

                if (rand.Next(2) == 0)
                    enemy = new Enemy("Slime", 120, EnemyWeakness.PrimeNumbers);
                else
                    enemy = new Enemy("Goblin", 120, EnemyWeakness.DivisibleBy3);

                //Player Attacks
                basicStrike = new Attack("Basic Strike", 10, AttackType.BasicStrike, enemyTarget => true);
                primeStrike = new Attack("Prime Strike", 20, AttackType.PrimeStrike, enemyTarget => IsPrime(enemyTarget.HP));
                modulusStrike = new Attack("Modulus Strike", 30, AttackType.ModulusStrike, enemyTarget => enemyTarget.HP % 3 == 0);


                //Show the player a message of the enemy that appears
                lblMessage.Text = $"A wild {enemy.Name} appears with {enemy.HP} HP!";
                lblMessage.AutoSize = true;
                lblMessage.Left = (this.ClientSize.Width - lblMessage.Width) / 2;
                UpdateHPLabels();

                //Reset action label messages
                //lblPlayerActions.Text = "";
                rtbBattleLog.Text = "";

                //Enable attack buttons
                btnBasicStrike.Enabled = true;
                btnPrimeStrike.Enabled = true;
                btnModulusStrike.Enabled = true;

                //Disable Start button
                btnStart.Enabled = false;

                //Update HP 
                UpdateHPLabels();
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please confirm your name before starting the game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #endregion

        #region Quit Button
        //Quit the game whenever users wants
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Confirm before quitting
            DialogResult result = MessageBox.Show("Are you sure you want to quit", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        #endregion


        #region Attack Buttons
        //BASIC STRIKE BUTTON
        private async void btnBasicStrike_Click(object sender, EventArgs e)
        {
            //Delay for attacks
            await PerformAttack(basicStrike);
        }

        //PRIME STRIKE BUTTON
        private async void btnPrimeStrike_Click(object sender, EventArgs e)
        {
            //Delay for attacks
            await PerformAttack(primeStrike);
        }


        // MODULUS STRIKE BUTTON
        private async void btnModulusStrike_Click(object sender, EventArgs e)
        {
            //Delay for attacks
            await PerformAttack(modulusStrike);
                   
        }


        #endregion


        #region Perform Attack
        // Executes a player attack and handles the enemy counter-attack
        private async Task PerformAttack(Attack attack)
        {
            //Disable attack buttons
            DisableAttackButtons();
            
            //if statement to check if method CanHit() applies, meaning if attack can be made
            if (attack.CanHit(enemy))
            {
                enemy.TakeDamage(attack.Damage);
                LogMessage($"\n{hero.Name} used {attack.Name} and did {attack.Damage} damage!", Color.Black);
            }

            else
            {
                LogMessage($"\n{hero.Name} used {attack.Name}, but it missed!", Color.Black);
            }

            //Check if enemy is defeated and print message
            if (!enemy.IsAlive())
            {
                LogMessage($"\n{enemy.Name} has been defeated!", Color.Green);
            }


            //Update HP
            UpdateHPLabels();

            if (!enemy.IsAlive())
            {
                //LogMessage($"{enemy.Name} has been defeated!", Color.Green);
                lblMessage.Text = "VICTORY!";
                CenterLabel(lblMessage);

                //Add scores for player at end of game
                EndGame(hero.Name, hero.HP);


                EndBattle();
                return;
            }
            //Await counter attack and enable attack buttons if player is alive
            await EnemyCounterAttack();

            if (hero.IsAlive())
            {
                EnableAttackButtons();
            }

        }

        #endregion


        #region Enemy Counter-attack 

        private async Task EnemyCounterAttack()
        {
           //2 second Delay for counter-attack
            await Task.Delay(2000);

            //Random rand = new Random()- declared at start
            int damage = rand.Next(5, 30);

            {
                hero.HP -= damage;
                if (hero.HP < 0) hero.HP = 0;
                //If statement to check if hero is alive and print message
                if (hero.HP == 0)
                {

                    LogMessage($"{enemy.Name} wins the battle!", Color.Red);

                    LogMessage($"\n{hero.Name} has been defeated!", Color.Red);

                    lblMessage.Text = "You Lose!\nGame Over";
                    lblMessage.AutoSize = true;
                    lblMessage.Left = (this.ClientSize.Width - lblMessage.Width) / 2;

                    //Add scores for player at end of game
                    EndGame(enemy.Name, enemy.HP);

                    EndBattle();
                    return;

                }
                //Else statment to show if enemy counter attacks 
                else
                {
                    rtbBattleLog.Text = $"{enemy.Name} counter-attacks for {damage} damage!" ;
                }

                //Update the health labels
                UpdateHPLabels();

                //Delay for attack
                await Task.Delay(2000);

            }
        }

        #endregion


        #region Helper Methods
        //Update HP Labels and Progress bars
        private void UpdateHPLabels()
        {   //If statement to prevent crash if hero or enemy is null
            if (hero == null)
            {

                MessageBox.Show("You must enter a player name first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enemy == null)
            {

                MessageBox.Show("You must start the battle first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //Label names for HP
            lblPlayerHP.Text = $"{hero.Name} HP: {hero.HP}";
            lblEnemyHP.Text = $"{enemy.Name} HP: {enemy.HP}";

            //Update health bars (progress bars)
            pgbPlayerHP.Value = Math.Max(0, hero.HP);
            pgbEnemyHP.Value = Math.Max(0, enemy.HP);

        }


        //Check if a number is Prime
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }


        //Ends the battle and disables attack buttons
        private void EndBattle()
        {
            DisableAttackButtons();
            btnStart.Enabled = true;
        }


        //Enables all attack buttons
        private void EnableAttackButtons()
        {
            btnBasicStrike.Enabled = true;
            btnPrimeStrike.Enabled = true;
            btnModulusStrike.Enabled = true;
        }


        //Disables all attack buttons
        private void DisableAttackButtons()
        {
            btnBasicStrike.Enabled = false;
            btnPrimeStrike.Enabled = false;
            btnModulusStrike.Enabled = false;
        }

        //Method for Battle Messages
        private void LogMessage(string message, Color color)
        {
            rtbBattleLog.SelectionStart = rtbBattleLog.TextLength;
            rtbBattleLog.SelectionLength = 0;

            rtbBattleLog.SelectionColor = color;
            rtbBattleLog.AppendText(message + Environment.NewLine);
            rtbBattleLog.SelectionColor = rtbBattleLog.ForeColor;
            rtbBattleLog.ScrollToCaret();

        }






        //Center a label horizontally
        private void CenterLabel(Label label)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }


        //ScoreManager method to add scores at the end of each game
        private void EndGame(string winnerName, int remainingHP)
        {
            scoreManager.AddScore(winnerName, remainingHP);
            scoreManager.SaveScores(scoreFile);
            scoreManager.DisplayScores(lbScores);

            MessageBox.Show($"{winnerName} wins with {remainingHP} HP left!");

        }

        //Method to clear scores
        private void ClearScores()
        {
            scoreManager = new ScoreManager();

            lbScores.Items.Clear();

            File.WriteAllText(scoreFile, string.Empty);

        }

        //Button to clear top scores
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all scores?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ClearScores();
            }

        }



        #endregion

       
    }
}
