namespace Calculette
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonZéro = new System.Windows.Forms.Button();
            this.buttonVirgule = new System.Windows.Forms.Button();
            this.buttonEgale = new System.Windows.Forms.Button();
            this.buttonDeux = new System.Windows.Forms.Button();
            this.buttonTrois = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonUn = new System.Windows.Forms.Button();
            this.buttonCinq = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSoustraction = new System.Windows.Forms.Button();
            this.buttonQuatre = new System.Windows.Forms.Button();
            this.buttonHuit = new System.Windows.Forms.Button();
            this.buttonNeuf = new System.Windows.Forms.Button();
            this.buttonProduit = new System.Windows.Forms.Button();
            this.buttonSept = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.ResultatText = new System.Windows.Forms.TextBox();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox.Controls.Add(this.buttonReturn);
            this.groupBox.Controls.Add(this.buttonMoins);
            this.groupBox.Controls.Add(this.buttonDivision);
            this.groupBox.Controls.Add(this.buttonZéro);
            this.groupBox.Controls.Add(this.buttonVirgule);
            this.groupBox.Controls.Add(this.buttonEgale);
            this.groupBox.Controls.Add(this.buttonDeux);
            this.groupBox.Controls.Add(this.buttonTrois);
            this.groupBox.Controls.Add(this.buttonMultiplication);
            this.groupBox.Controls.Add(this.buttonUn);
            this.groupBox.Controls.Add(this.buttonCinq);
            this.groupBox.Controls.Add(this.buttonSix);
            this.groupBox.Controls.Add(this.buttonSoustraction);
            this.groupBox.Controls.Add(this.buttonQuatre);
            this.groupBox.Controls.Add(this.buttonHuit);
            this.groupBox.Controls.Add(this.buttonNeuf);
            this.groupBox.Controls.Add(this.buttonProduit);
            this.groupBox.Controls.Add(this.buttonSept);
            this.groupBox.Controls.Add(this.buttonSupprimer);
            this.groupBox.Controls.Add(this.buttonCE);
            this.groupBox.Location = new System.Drawing.Point(3, 100);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(262, 263);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // buttonZéro
            // 
            this.buttonZéro.BackColor = System.Drawing.SystemColors.Control;
            this.buttonZéro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZéro.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZéro.Location = new System.Drawing.Point(71, 206);
            this.buttonZéro.Name = "buttonZéro";
            this.buttonZéro.Size = new System.Drawing.Size(56, 44);
            this.buttonZéro.TabIndex = 19;
            this.buttonZéro.Text = "0";
            this.buttonZéro.UseVisualStyleBackColor = false;
            this.buttonZéro.Click += new System.EventHandler(this.button_click);
            // 
            // buttonVirgule
            // 
            this.buttonVirgule.BackColor = System.Drawing.SystemColors.Control;
            this.buttonVirgule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVirgule.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgule.Location = new System.Drawing.Point(133, 206);
            this.buttonVirgule.Name = "buttonVirgule";
            this.buttonVirgule.Size = new System.Drawing.Size(56, 44);
            this.buttonVirgule.TabIndex = 18;
            this.buttonVirgule.Text = ".";
            this.buttonVirgule.UseVisualStyleBackColor = false;
            this.buttonVirgule.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEgale
            // 
            this.buttonEgale.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEgale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEgale.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEgale.Location = new System.Drawing.Point(195, 206);
            this.buttonEgale.Name = "buttonEgale";
            this.buttonEgale.Size = new System.Drawing.Size(56, 44);
            this.buttonEgale.TabIndex = 17;
            this.buttonEgale.Text = "=";
            this.buttonEgale.UseVisualStyleBackColor = false;
            this.buttonEgale.Click += new System.EventHandler(this.Egale_click);
            // 
            // buttonDeux
            // 
            this.buttonDeux.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDeux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeux.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeux.Location = new System.Drawing.Point(71, 160);
            this.buttonDeux.Name = "buttonDeux";
            this.buttonDeux.Size = new System.Drawing.Size(56, 44);
            this.buttonDeux.TabIndex = 15;
            this.buttonDeux.Text = "2";
            this.buttonDeux.UseVisualStyleBackColor = false;
            this.buttonDeux.Click += new System.EventHandler(this.button_click);
            // 
            // buttonTrois
            // 
            this.buttonTrois.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTrois.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTrois.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrois.Location = new System.Drawing.Point(133, 160);
            this.buttonTrois.Name = "buttonTrois";
            this.buttonTrois.Size = new System.Drawing.Size(56, 44);
            this.buttonTrois.TabIndex = 14;
            this.buttonTrois.Text = "3";
            this.buttonTrois.UseVisualStyleBackColor = false;
            this.buttonTrois.Click += new System.EventHandler(this.button_click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(195, 19);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(56, 44);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Text = "+";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonUn
            // 
            this.buttonUn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUn.Location = new System.Drawing.Point(9, 160);
            this.buttonUn.Name = "buttonUn";
            this.buttonUn.Size = new System.Drawing.Size(56, 44);
            this.buttonUn.TabIndex = 12;
            this.buttonUn.Text = "1";
            this.buttonUn.UseVisualStyleBackColor = false;
            this.buttonUn.Click += new System.EventHandler(this.button_click);
            // 
            // buttonCinq
            // 
            this.buttonCinq.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCinq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCinq.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinq.Location = new System.Drawing.Point(71, 115);
            this.buttonCinq.Name = "buttonCinq";
            this.buttonCinq.Size = new System.Drawing.Size(56, 44);
            this.buttonCinq.TabIndex = 11;
            this.buttonCinq.Text = "5";
            this.buttonCinq.UseVisualStyleBackColor = false;
            this.buttonCinq.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(133, 115);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(56, 44);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSoustraction
            // 
            this.buttonSoustraction.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSoustraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSoustraction.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoustraction.Location = new System.Drawing.Point(195, 160);
            this.buttonSoustraction.Name = "buttonSoustraction";
            this.buttonSoustraction.Size = new System.Drawing.Size(56, 44);
            this.buttonSoustraction.TabIndex = 9;
            this.buttonSoustraction.Text = "-";
            this.buttonSoustraction.UseVisualStyleBackColor = false;
            this.buttonSoustraction.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonQuatre
            // 
            this.buttonQuatre.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQuatre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuatre.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuatre.Location = new System.Drawing.Point(9, 115);
            this.buttonQuatre.Name = "buttonQuatre";
            this.buttonQuatre.Size = new System.Drawing.Size(56, 44);
            this.buttonQuatre.TabIndex = 8;
            this.buttonQuatre.Text = "4";
            this.buttonQuatre.UseVisualStyleBackColor = false;
            this.buttonQuatre.Click += new System.EventHandler(this.button_click);
            // 
            // buttonHuit
            // 
            this.buttonHuit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHuit.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuit.Location = new System.Drawing.Point(71, 69);
            this.buttonHuit.Name = "buttonHuit";
            this.buttonHuit.Size = new System.Drawing.Size(56, 44);
            this.buttonHuit.TabIndex = 7;
            this.buttonHuit.Text = "8";
            this.buttonHuit.UseVisualStyleBackColor = false;
            this.buttonHuit.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNeuf
            // 
            this.buttonNeuf.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNeuf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNeuf.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeuf.Location = new System.Drawing.Point(133, 69);
            this.buttonNeuf.Name = "buttonNeuf";
            this.buttonNeuf.Size = new System.Drawing.Size(56, 44);
            this.buttonNeuf.TabIndex = 6;
            this.buttonNeuf.Text = "9";
            this.buttonNeuf.UseVisualStyleBackColor = false;
            this.buttonNeuf.Click += new System.EventHandler(this.button_click);
            // 
            // buttonProduit
            // 
            this.buttonProduit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonProduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProduit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduit.Location = new System.Drawing.Point(195, 115);
            this.buttonProduit.Name = "buttonProduit";
            this.buttonProduit.Size = new System.Drawing.Size(56, 44);
            this.buttonProduit.TabIndex = 5;
            this.buttonProduit.Text = "x";
            this.buttonProduit.UseVisualStyleBackColor = false;
            this.buttonProduit.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonSept
            // 
            this.buttonSept.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSept.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSept.Location = new System.Drawing.Point(9, 69);
            this.buttonSept.Name = "buttonSept";
            this.buttonSept.Size = new System.Drawing.Size(56, 44);
            this.buttonSept.TabIndex = 4;
            this.buttonSept.Text = "7";
            this.buttonSept.UseVisualStyleBackColor = false;
            this.buttonSept.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(133, 19);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(56, 44);
            this.buttonSupprimer.TabIndex = 3;
            this.buttonSupprimer.Text = "C";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonC_click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(195, 69);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(56, 44);
            this.buttonDivision.TabIndex = 1;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(71, 19);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(56, 44);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_click);
            // 
            // ResultatText
            // 
            this.ResultatText.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatText.Location = new System.Drawing.Point(3, 12);
            this.ResultatText.Multiline = true;
            this.ResultatText.Name = "ResultatText";
            this.ResultatText.Size = new System.Drawing.Size(262, 82);
            this.ResultatText.TabIndex = 4;
            this.ResultatText.Text = "0";
            this.ResultatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMoins
            // 
            this.buttonMoins.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.Location = new System.Drawing.Point(9, 207);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(56, 44);
            this.buttonMoins.TabIndex = 20;
            this.buttonMoins.Text = "+/-";
            this.buttonMoins.UseVisualStyleBackColor = false;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReturn.Location = new System.Drawing.Point(9, 19);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(56, 44);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.Text = "";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 375);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ResultatText);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonZéro;
        private System.Windows.Forms.Button buttonVirgule;
        private System.Windows.Forms.Button buttonEgale;
        private System.Windows.Forms.Button buttonDeux;
        private System.Windows.Forms.Button buttonTrois;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonUn;
        private System.Windows.Forms.Button buttonCinq;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSoustraction;
        private System.Windows.Forms.Button buttonQuatre;
        private System.Windows.Forms.Button buttonHuit;
        private System.Windows.Forms.Button buttonNeuf;
        private System.Windows.Forms.Button buttonProduit;
        private System.Windows.Forms.Button buttonSept;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.TextBox ResultatText;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonMoins;
    }
}

