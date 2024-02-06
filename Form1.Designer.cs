

namespace Lab_2_The_Quest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        


        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttackDown = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPointsLabel = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPointsLabel = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.nameHitPointsLabel = new System.Windows.Forms.Label();
            this.batHitPointsLabel = new System.Windows.Forms.Label();
            this.swordInventory = new System.Windows.Forms.PictureBox();
            this.redPotionInventory = new System.Windows.Forms.PictureBox();
            this.bowInventory = new System.Windows.Forms.PictureBox();
            this.maceInventory = new System.Windows.Forms.PictureBox();
            this.bluePotionInventory = new System.Windows.Forms.PictureBox();
            this.swordCharacter = new System.Windows.Forms.PictureBox();
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.batCharacter = new System.Windows.Forms.PictureBox();
            this.ghoulCharacter = new System.Windows.Forms.PictureBox();
            this.ghostCharacter = new System.Windows.Forms.PictureBox();
            this.bowCharacter = new System.Windows.Forms.PictureBox();
            this.bluePotionCharacter = new System.Windows.Forms.PictureBox();
            this.redPotionCharacter = new System.Windows.Forms.PictureBox();
            this.maceCharacter = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9337F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(597, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.04688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.95313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MoveDown);
            this.groupBox1.Controls.Add(this.MoveRight);
            this.groupBox1.Controls.Add(this.MoveLeft);
            this.groupBox1.Controls.Add(this.MoveUp);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(64, 76);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(75, 23);
            this.MoveDown.TabIndex = 4;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(100, 47);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(75, 23);
            this.MoveRight.TabIndex = 3;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(19, 48);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft.TabIndex = 2;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(64, 19);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(75, 23);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AttackDown);
            this.panel1.Controls.Add(this.AttackRight);
            this.panel1.Controls.Add(this.AttackLeft);
            this.panel1.Controls.Add(this.AttackUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 117);
            this.panel1.TabIndex = 1;
            // 
            // AttackDown
            // 
            this.AttackDown.Location = new System.Drawing.Point(63, 78);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(75, 23);
            this.AttackDown.TabIndex = 4;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Location = new System.Drawing.Point(113, 49);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(75, 23);
            this.AttackRight.TabIndex = 3;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Location = new System.Drawing.Point(32, 49);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(75, 23);
            this.AttackLeft.TabIndex = 2;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackUp
            // 
            this.AttackUp.Location = new System.Drawing.Point(64, 20);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(75, 23);
            this.AttackUp.TabIndex = 1;
            this.AttackUp.Text = "Up";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attack";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ghoulHitPointsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ghostHitPointsLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameHitPointsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.batHitPointsLabel, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 239);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 155);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(103, 114);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghoulHitPointsLabel
            // 
            this.ghoulHitPointsLabel.AutoSize = true;
            this.ghoulHitPointsLabel.Location = new System.Drawing.Point(3, 114);
            this.ghoulHitPointsLabel.Name = "ghoulHitPointsLabel";
            this.ghoulHitPointsLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulHitPointsLabel.TabIndex = 6;
            this.ghoulHitPointsLabel.Text = "Ghoul";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(103, 76);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghostHitPointsLabel
            // 
            this.ghostHitPointsLabel.AutoSize = true;
            this.ghostHitPointsLabel.Location = new System.Drawing.Point(3, 76);
            this.ghostHitPointsLabel.Name = "ghostHitPointsLabel";
            this.ghostHitPointsLabel.Size = new System.Drawing.Size(35, 13);
            this.ghostHitPointsLabel.TabIndex = 4;
            this.ghostHitPointsLabel.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(103, 38);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(63, 13);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitpoints";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(103, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(76, 13);
            this.playerHitPoints.TabIndex = 2;
            this.playerHitPoints.Text = "playerHitpoints";
            // 
            // nameHitPointsLabel
            // 
            this.nameHitPointsLabel.AutoSize = true;
            this.nameHitPointsLabel.Location = new System.Drawing.Point(3, 0);
            this.nameHitPointsLabel.Name = "nameHitPointsLabel";
            this.nameHitPointsLabel.Size = new System.Drawing.Size(36, 13);
            this.nameHitPointsLabel.TabIndex = 0;
            this.nameHitPointsLabel.Text = "Player";
            // 
            // batHitPointsLabel
            // 
            this.batHitPointsLabel.AutoSize = true;
            this.batHitPointsLabel.Location = new System.Drawing.Point(3, 38);
            this.batHitPointsLabel.Name = "batHitPointsLabel";
            this.batHitPointsLabel.Size = new System.Drawing.Size(23, 13);
            this.batHitPointsLabel.TabIndex = 1;
            this.batHitPointsLabel.Text = "Bat";
            // 
            // swordInventory
            // 
            this.swordInventory.BackColor = System.Drawing.Color.Transparent;
            this.swordInventory.Image = ((System.Drawing.Image)(resources.GetObject("swordInventory.Image")));
            this.swordInventory.Location = new System.Drawing.Point(76, 316);
            this.swordInventory.Name = "swordInventory";
            this.swordInventory.Size = new System.Drawing.Size(56, 50);
            this.swordInventory.TabIndex = 1;
            this.swordInventory.TabStop = false;
            this.swordInventory.Click += new System.EventHandler(this.swordInventory_Click);
            // 
            // redPotionInventory
            // 
            this.redPotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.redPotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("redPotionInventory.Image")));
            this.redPotionInventory.Location = new System.Drawing.Point(138, 317);
            this.redPotionInventory.Name = "redPotionInventory";
            this.redPotionInventory.Size = new System.Drawing.Size(56, 50);
            this.redPotionInventory.TabIndex = 2;
            this.redPotionInventory.TabStop = false;
            this.redPotionInventory.Click += new System.EventHandler(this.redPotionInventory_Click);
            // 
            // bowInventory
            // 
            this.bowInventory.BackColor = System.Drawing.Color.Transparent;
            this.bowInventory.Image = ((System.Drawing.Image)(resources.GetObject("bowInventory.Image")));
            this.bowInventory.Location = new System.Drawing.Point(200, 317);
            this.bowInventory.Name = "bowInventory";
            this.bowInventory.Size = new System.Drawing.Size(56, 50);
            this.bowInventory.TabIndex = 3;
            this.bowInventory.TabStop = false;
            this.bowInventory.Click += new System.EventHandler(this.bowInventory_Click);
            // 
            // maceInventory
            // 
            this.maceInventory.BackColor = System.Drawing.Color.Transparent;
            this.maceInventory.Image = ((System.Drawing.Image)(resources.GetObject("maceInventory.Image")));
            this.maceInventory.Location = new System.Drawing.Point(324, 316);
            this.maceInventory.Name = "maceInventory";
            this.maceInventory.Size = new System.Drawing.Size(56, 50);
            this.maceInventory.TabIndex = 5;
            this.maceInventory.TabStop = false;
            this.maceInventory.Click += new System.EventHandler(this.maceInventory_Click);
            // 
            // bluePotionInventory
            // 
            this.bluePotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionInventory.Image")));
            this.bluePotionInventory.Location = new System.Drawing.Point(262, 316);
            this.bluePotionInventory.Name = "bluePotionInventory";
            this.bluePotionInventory.Size = new System.Drawing.Size(56, 50);
            this.bluePotionInventory.TabIndex = 4;
            this.bluePotionInventory.TabStop = false;
            this.bluePotionInventory.Click += new System.EventHandler(this.bluePotionInventory_Click);
            // 
            // swordCharacter
            // 
            this.swordCharacter.BackColor = System.Drawing.Color.Transparent;
            this.swordCharacter.Image = ((System.Drawing.Image)(resources.GetObject("swordCharacter.Image")));
            this.swordCharacter.Location = new System.Drawing.Point(116, 61);
            this.swordCharacter.Name = "swordCharacter";
            this.swordCharacter.Size = new System.Drawing.Size(32, 32);
            this.swordCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swordCharacter.TabIndex = 6;
            this.swordCharacter.TabStop = false;
            this.swordCharacter.Visible = false;
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter.Image = ((System.Drawing.Image)(resources.GetObject("playerCharacter.Image")));
            this.playerCharacter.Location = new System.Drawing.Point(78, 61);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(32, 32);
            this.playerCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCharacter.TabIndex = 7;
            this.playerCharacter.TabStop = false;
            // 
            // batCharacter
            // 
            this.batCharacter.BackColor = System.Drawing.Color.Transparent;
            this.batCharacter.Image = ((System.Drawing.Image)(resources.GetObject("batCharacter.Image")));
            this.batCharacter.Location = new System.Drawing.Point(154, 61);
            this.batCharacter.Name = "batCharacter";
            this.batCharacter.Size = new System.Drawing.Size(32, 32);
            this.batCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.batCharacter.TabIndex = 8;
            this.batCharacter.TabStop = false;
            this.batCharacter.Visible = false;
            // 
            // ghoulCharacter
            // 
            this.ghoulCharacter.BackColor = System.Drawing.Color.Transparent;
            this.ghoulCharacter.Image = ((System.Drawing.Image)(resources.GetObject("ghoulCharacter.Image")));
            this.ghoulCharacter.Location = new System.Drawing.Point(192, 61);
            this.ghoulCharacter.Name = "ghoulCharacter";
            this.ghoulCharacter.Size = new System.Drawing.Size(32, 32);
            this.ghoulCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghoulCharacter.TabIndex = 9;
            this.ghoulCharacter.TabStop = false;
            this.ghoulCharacter.Visible = false;
            // 
            // ghostCharacter
            // 
            this.ghostCharacter.BackColor = System.Drawing.Color.Transparent;
            this.ghostCharacter.Image = ((System.Drawing.Image)(resources.GetObject("ghostCharacter.Image")));
            this.ghostCharacter.Location = new System.Drawing.Point(230, 61);
            this.ghostCharacter.Name = "ghostCharacter";
            this.ghostCharacter.Size = new System.Drawing.Size(32, 32);
            this.ghostCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghostCharacter.TabIndex = 10;
            this.ghostCharacter.TabStop = false;
            this.ghostCharacter.Visible = false;
            // 
            // bowCharacter
            // 
            this.bowCharacter.BackColor = System.Drawing.Color.Transparent;
            this.bowCharacter.Image = ((System.Drawing.Image)(resources.GetObject("bowCharacter.Image")));
            this.bowCharacter.Location = new System.Drawing.Point(268, 61);
            this.bowCharacter.Name = "bowCharacter";
            this.bowCharacter.Size = new System.Drawing.Size(32, 32);
            this.bowCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bowCharacter.TabIndex = 11;
            this.bowCharacter.TabStop = false;
            this.bowCharacter.Visible = false;
            // 
            // bluePotionCharacter
            // 
            this.bluePotionCharacter.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionCharacter.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionCharacter.Image")));
            this.bluePotionCharacter.Location = new System.Drawing.Point(306, 61);
            this.bluePotionCharacter.Name = "bluePotionCharacter";
            this.bluePotionCharacter.Size = new System.Drawing.Size(32, 32);
            this.bluePotionCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bluePotionCharacter.TabIndex = 12;
            this.bluePotionCharacter.TabStop = false;
            this.bluePotionCharacter.Visible = false;
            // 
            // redPotionCharacter
            // 
            this.redPotionCharacter.BackColor = System.Drawing.Color.Transparent;
            this.redPotionCharacter.Image = ((System.Drawing.Image)(resources.GetObject("redPotionCharacter.Image")));
            this.redPotionCharacter.Location = new System.Drawing.Point(344, 61);
            this.redPotionCharacter.Name = "redPotionCharacter";
            this.redPotionCharacter.Size = new System.Drawing.Size(32, 32);
            this.redPotionCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redPotionCharacter.TabIndex = 13;
            this.redPotionCharacter.TabStop = false;
            this.redPotionCharacter.Visible = false;
            // 
            // maceCharacter
            // 
            this.maceCharacter.BackColor = System.Drawing.Color.Transparent;
            this.maceCharacter.Image = ((System.Drawing.Image)(resources.GetObject("maceCharacter.Image")));
            this.maceCharacter.Location = new System.Drawing.Point(382, 61);
            this.maceCharacter.Name = "maceCharacter";
            this.maceCharacter.Size = new System.Drawing.Size(32, 32);
            this.maceCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maceCharacter.TabIndex = 14;
            this.maceCharacter.TabStop = false;
            this.maceCharacter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.ghostCharacter);
            this.Controls.Add(this.ghoulCharacter);
            this.Controls.Add(this.batCharacter);
            this.Controls.Add(this.maceInventory);
            this.Controls.Add(this.bluePotionInventory);
            this.Controls.Add(this.bowInventory);
            this.Controls.Add(this.redPotionInventory);
            this.Controls.Add(this.swordInventory);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.swordCharacter);
            this.Controls.Add(this.maceCharacter);
            this.Controls.Add(this.bowCharacter);
            this.Controls.Add(this.redPotionCharacter);
            this.Controls.Add(this.bluePotionCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghoulHitPointsLabel;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghostHitPointsLabel;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label nameHitPointsLabel;
        private System.Windows.Forms.Label batHitPointsLabel;
        private System.Windows.Forms.PictureBox swordInventory;
        private System.Windows.Forms.PictureBox redPotionInventory;
        private System.Windows.Forms.PictureBox bowInventory;
        private System.Windows.Forms.PictureBox maceInventory;
        private System.Windows.Forms.PictureBox bluePotionInventory;
        private System.Windows.Forms.PictureBox swordCharacter;
        private System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.PictureBox batCharacter;
        private System.Windows.Forms.PictureBox ghoulCharacter;
        private System.Windows.Forms.PictureBox ghostCharacter;
        private System.Windows.Forms.PictureBox bowCharacter;
        private System.Windows.Forms.PictureBox bluePotionCharacter;
        private System.Windows.Forms.PictureBox redPotionCharacter;
        private System.Windows.Forms.PictureBox maceCharacter;
    }
}

