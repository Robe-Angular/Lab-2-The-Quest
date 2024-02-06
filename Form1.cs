using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_The_Quest
{
    public partial class Form1 : Form
    {

        private Game game;
        private Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void makeWeaponVisibleIfNotEquipped(bool condition, string weaponName,
            PictureBox weaponCharacter)
        {
            if (condition && !game.PlayerWeapons.Contains(weaponName))
            {
                weaponCharacter.Visible = true;
            }
        }

        private void makeEnemyVisibleIfNotDead(Enemy enemy,bool condition,
            PictureBox enemyCharacter, Label hitPointsEnemy)
        {
            if (condition && enemy.Dead == false)
            {
                enemyCharacter.Visible = true;
                enemyCharacter.Location = enemy.Location;
                hitPointsEnemy.Text = enemy.Hitpoints.ToString();
            }
        }

        private void invisibleWeaponOnInventory(string weaponName, PictureBox weaponPicture )
        {
            if (!game.CheckPlayerInventory(weaponName))
            {
                weaponPicture.Visible = false;
            }
            else
            {
                weaponPicture.Visible = true;
            }
        }


        private void UpdateCharacters()
        {
            playerCharacter.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            int numberEnemies = game.Enemies.Count();
            
            int enemiesDead = 0;
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died, Game Over");
                Application.Exit();
            }
                

            foreach(Enemy enemy in game.Enemies)
            {
                
                if (enemy.Dead)
                {
                    enemiesDead++;
                }
                    
            }
            
            if (enemiesDead == numberEnemies)
            {
                MessageBox.Show("You have defeated all enemies on this level");
                if(game.Level == 7)
                {
                    MessageBox.Show("You win");
                }
                game.NewLevel(random);
            }
                
            

            PictureBox[] weaponPictures = { swordCharacter, bowCharacter, maceCharacter,
                bluePotionCharacter, redPotionCharacter};
            PictureBox[] enemiesPictures = { ghostCharacter, ghoulCharacter, batCharacter };

            invisibleWeaponOnInventory("Sword", swordInventory);
            invisibleWeaponOnInventory("Bow", bowInventory);
            invisibleWeaponOnInventory("Mace", maceInventory);
            invisibleWeaponOnInventory("Blue potion", bluePotionInventory);
            invisibleWeaponOnInventory("Red potion", redPotionInventory);

            foreach(PictureBox weaponPicture in weaponPictures)
            {
                weaponPicture.Location = game.WeaponInRoom.Location;
                weaponPicture.Visible = false;
            }

            makeWeaponVisibleIfNotEquipped(game.WeaponInRoom is Sword, "Sword", swordCharacter);
            makeWeaponVisibleIfNotEquipped(game.WeaponInRoom is Mace, "Mace", maceCharacter);
            makeWeaponVisibleIfNotEquipped(game.WeaponInRoom is Bow, "Bow", bowCharacter);
            makeWeaponVisibleIfNotEquipped(game.WeaponInRoom is BluePotion, "Blue potion"
                , bluePotionCharacter);
            makeWeaponVisibleIfNotEquipped(game.WeaponInRoom is RedPotion, "Red potion"
                , redPotionCharacter);


            foreach (PictureBox enemyPicture in enemiesPictures)
            {
                enemyPicture.Visible = false;
                
            }
            foreach (Enemy enemy in game.Enemies)
            {
                makeEnemyVisibleIfNotDead(enemy, enemy is Bat, batCharacter,batHitPoints);
                makeEnemyVisibleIfNotDead(enemy, enemy is Ghost, ghostCharacter,ghostHitPoints);
                makeEnemyVisibleIfNotDead(enemy, enemy is Ghoul, ghoulCharacter, ghoulHitPoints);
            }


        }

        private void boxAroundWeapon(PictureBox weaponPicture)
        {
            PictureBox[] pictureBoxArray = { redPotionInventory, bluePotionInventory, bowInventory,
                swordInventory, maceInventory};
            foreach(PictureBox pictureBox in pictureBoxArray)
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            weaponPicture.BorderStyle = BorderStyle.FixedSingle;
        }

        private void makeAttackButtonsInvisible()
        {
            AttackUp.Text = "Drink";
            AttackDown.Visible = false;
            AttackLeft.Visible = false;
            AttackRight.Visible = false;

        }

        private void makeAttackButtonsVisible()
        {
            AttackUp.Text = "Up";
            AttackDown.Visible = true;
            AttackLeft.Visible = true;
            AttackRight.Visible = true;

        }
        private void swordInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                boxAroundWeapon(swordInventory);
                makeAttackButtonsVisible();
            }
            
        }

        private void redPotionInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red potion"))
            {
                game.Equip("Red potion");
                boxAroundWeapon(redPotionInventory);
                makeAttackButtonsInvisible();
            }
            

        }

        private void bowInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                boxAroundWeapon(bowInventory);
                makeAttackButtonsVisible();
            }
                
        }

        private void bluePotionInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue potion"))
            {
                game.Equip("Blue potion");
                boxAroundWeapon(bluePotionInventory);
                makeAttackButtonsInvisible();
            }
                
        }

        private void maceInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                boxAroundWeapon(maceInventory);
                makeAttackButtonsVisible();
            }
            
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {

            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
    }
}
