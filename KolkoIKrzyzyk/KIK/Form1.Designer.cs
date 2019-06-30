namespace KIK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGlowneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijGreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zasadyGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xWinCounter = new System.Windows.Forms.Label();
            this.drawCounter = new System.Windows.Forms.Label();
            this.oWinCounter = new System.Windows.Forms.Label();
            this.zresetujLicznikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraTrybAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGlowneToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGlowneToolStripMenuItem
            // 
            this.menuGlowneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.nowaGraTrybAIToolStripMenuItem,
            this.zresetujLicznikiToolStripMenuItem,
            this.zamknijGreToolStripMenuItem});
            this.menuGlowneToolStripMenuItem.Name = "menuGlowneToolStripMenuItem";
            this.menuGlowneToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuGlowneToolStripMenuItem.Text = "Menu Glowne";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa Gra bez AI";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // zamknijGreToolStripMenuItem
            // 
            this.zamknijGreToolStripMenuItem.Name = "zamknijGreToolStripMenuItem";
            this.zamknijGreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijGreToolStripMenuItem.Text = "Zamknij Gre";
            this.zamknijGreToolStripMenuItem.Click += new System.EventHandler(this.zamknijGreToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zasadyGryToolStripMenuItem,
            this.oAutorzeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // zasadyGryToolStripMenuItem
            // 
            this.zasadyGryToolStripMenuItem.Name = "zasadyGryToolStripMenuItem";
            this.zasadyGryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zasadyGryToolStripMenuItem.Text = "Zasady Gry";
            this.zasadyGryToolStripMenuItem.Click += new System.EventHandler(this.zasadyGryToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oAutorzeToolStripMenuItem.Text = "O Autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(23, 45);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(80, 80);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.clickLogic);
            this.A1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(118, 45);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(80, 80);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.clickLogic);
            this.A2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.A3.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(214, 45);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(80, 80);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.clickLogic);
            this.A3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B3.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B3.Location = new System.Drawing.Point(214, 141);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 80);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.clickLogic);
            this.B3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B2.Location = new System.Drawing.Point(118, 141);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 80);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.clickLogic);
            this.B2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(23, 141);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 80);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.clickLogic);
            this.B1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C3.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C3.Location = new System.Drawing.Point(214, 236);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(80, 80);
            this.C3.TabIndex = 7;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.clickLogic);
            this.C3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C2.Location = new System.Drawing.Point(118, 236);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(80, 80);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.clickLogic);
            this.C2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.C1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C1.Location = new System.Drawing.Point(23, 236);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(80, 80);
            this.C1.TabIndex = 9;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.clickLogic);
            this.C1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wygrane X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remisy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(215, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wygrane O:";
            // 
            // xWinCounter
            // 
            this.xWinCounter.AutoSize = true;
            this.xWinCounter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xWinCounter.Location = new System.Drawing.Point(49, 363);
            this.xWinCounter.Name = "xWinCounter";
            this.xWinCounter.Size = new System.Drawing.Size(17, 19);
            this.xWinCounter.TabIndex = 13;
            this.xWinCounter.Text = "0";
            // 
            // drawCounter
            // 
            this.drawCounter.AutoSize = true;
            this.drawCounter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawCounter.Location = new System.Drawing.Point(147, 363);
            this.drawCounter.Name = "drawCounter";
            this.drawCounter.Size = new System.Drawing.Size(17, 19);
            this.drawCounter.TabIndex = 14;
            this.drawCounter.Text = "0";
            // 
            // oWinCounter
            // 
            this.oWinCounter.AutoSize = true;
            this.oWinCounter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oWinCounter.Location = new System.Drawing.Point(245, 363);
            this.oWinCounter.Name = "oWinCounter";
            this.oWinCounter.Size = new System.Drawing.Size(17, 19);
            this.oWinCounter.TabIndex = 15;
            this.oWinCounter.Text = "0";
            // 
            // zresetujLicznikiToolStripMenuItem
            // 
            this.zresetujLicznikiToolStripMenuItem.Name = "zresetujLicznikiToolStripMenuItem";
            this.zresetujLicznikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zresetujLicznikiToolStripMenuItem.Text = "Zresetuj Liczniki";
            this.zresetujLicznikiToolStripMenuItem.Click += new System.EventHandler(this.zresetujLicznikiToolStripMenuItem_Click);
            // 
            // nowaGraTrybAIToolStripMenuItem
            // 
            this.nowaGraTrybAIToolStripMenuItem.Name = "nowaGraTrybAIToolStripMenuItem";
            this.nowaGraTrybAIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowaGraTrybAIToolStripMenuItem.Text = "Nowa Gra Tryb AI";
            this.nowaGraTrybAIToolStripMenuItem.Click += new System.EventHandler(this.nowaGraTrybAIToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tryb gry z AI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oWinCounter);
            this.Controls.Add(this.drawCounter);
            this.Controls.Add(this.xWinCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kolko i krzyzyk - wombatwsei 2019";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGlowneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijGreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zasadyGryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xWinCounter;
        private System.Windows.Forms.Label drawCounter;
        private System.Windows.Forms.Label oWinCounter;
        private System.Windows.Forms.ToolStripMenuItem zresetujLicznikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraTrybAIToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

