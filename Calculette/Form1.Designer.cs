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
            this.ResultatText = new System.Windows.Forms.TextBox();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonSept = new System.Windows.Forms.Button();
            this.buttonProduit = new System.Windows.Forms.Button();
            this.buttonNeuf = new System.Windows.Forms.Button();
            this.buttonHuit = new System.Windows.Forms.Button();
            this.buttonQuatre = new System.Windows.Forms.Button();
            this.buttonSoustraction = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonCinq = new System.Windows.Forms.Button();
            this.buttonUn = new System.Windows.Forms.Button();
            this.buttonTrois = new System.Windows.Forms.Button();
            this.buttonDeux = new System.Windows.Forms.Button();
            this.buttonEgale = new System.Windows.Forms.Button();
            this.buttonVirgule = new System.Windows.Forms.Button();
            this.buttonZéro = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultatText
            // 
            this.ResultatText.BackColor = System.Drawing.Color.Silver;
            this.ResultatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultatText.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatText.Location = new System.Drawing.Point(2, 36);
            this.ResultatText.Multiline = true;
            this.ResultatText.Name = "ResultatText";
            this.ResultatText.Size = new System.Drawing.Size(264, 43);
            this.ResultatText.TabIndex = 4;
            this.ResultatText.Text = "0";
            this.ResultatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCE
            // 
            this.buttonCE.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCE.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(68, 85);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(67, 60);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSupprimer.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Location = new System.Drawing.Point(134, 85);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(67, 60);
            this.buttonSupprimer.TabIndex = 3;
            this.buttonSupprimer.Text = "C";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonC_click);
            // 
            // buttonSept
            // 
            this.buttonSept.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSept.BackColor = System.Drawing.Color.White;
            this.buttonSept.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSept.Location = new System.Drawing.Point(2, 145);
            this.buttonSept.Name = "buttonSept";
            this.buttonSept.Size = new System.Drawing.Size(67, 60);
            this.buttonSept.TabIndex = 4;
            this.buttonSept.Text = "7";
            this.buttonSept.UseVisualStyleBackColor = false;
            this.buttonSept.Click += new System.EventHandler(this.button_click);
            // 
            // buttonProduit
            // 
            this.buttonProduit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonProduit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProduit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.buttonProduit.Location = new System.Drawing.Point(200, 145);
            this.buttonProduit.Name = "buttonProduit";
            this.buttonProduit.Size = new System.Drawing.Size(67, 60);
            this.buttonProduit.TabIndex = 5;
            this.buttonProduit.Text = "x";
            this.buttonProduit.UseVisualStyleBackColor = false;
            this.buttonProduit.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonNeuf
            // 
            this.buttonNeuf.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonNeuf.BackColor = System.Drawing.Color.White;
            this.buttonNeuf.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeuf.Location = new System.Drawing.Point(134, 145);
            this.buttonNeuf.Name = "buttonNeuf";
            this.buttonNeuf.Size = new System.Drawing.Size(67, 60);
            this.buttonNeuf.TabIndex = 6;
            this.buttonNeuf.Text = "9";
            this.buttonNeuf.UseVisualStyleBackColor = false;
            this.buttonNeuf.Click += new System.EventHandler(this.button_click);
            // 
            // buttonHuit
            // 
            this.buttonHuit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonHuit.BackColor = System.Drawing.Color.White;
            this.buttonHuit.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuit.Location = new System.Drawing.Point(68, 145);
            this.buttonHuit.Name = "buttonHuit";
            this.buttonHuit.Size = new System.Drawing.Size(67, 60);
            this.buttonHuit.TabIndex = 7;
            this.buttonHuit.Text = "8";
            this.buttonHuit.UseVisualStyleBackColor = false;
            this.buttonHuit.Click += new System.EventHandler(this.button_click);
            // 
            // buttonQuatre
            // 
            this.buttonQuatre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonQuatre.BackColor = System.Drawing.Color.White;
            this.buttonQuatre.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuatre.Location = new System.Drawing.Point(2, 205);
            this.buttonQuatre.Name = "buttonQuatre";
            this.buttonQuatre.Size = new System.Drawing.Size(67, 60);
            this.buttonQuatre.TabIndex = 8;
            this.buttonQuatre.Text = "4";
            this.buttonQuatre.UseVisualStyleBackColor = false;
            this.buttonQuatre.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSoustraction
            // 
            this.buttonSoustraction.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSoustraction.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSoustraction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSoustraction.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.buttonSoustraction.Location = new System.Drawing.Point(200, 205);
            this.buttonSoustraction.Name = "buttonSoustraction";
            this.buttonSoustraction.Size = new System.Drawing.Size(67, 60);
            this.buttonSoustraction.TabIndex = 9;
            this.buttonSoustraction.Text = "-";
            this.buttonSoustraction.UseVisualStyleBackColor = false;
            this.buttonSoustraction.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonSix
            // 
            this.buttonSix.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSix.BackColor = System.Drawing.Color.White;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(134, 205);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(67, 60);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_click);
            // 
            // buttonCinq
            // 
            this.buttonCinq.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCinq.BackColor = System.Drawing.Color.White;
            this.buttonCinq.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinq.Location = new System.Drawing.Point(68, 205);
            this.buttonCinq.Name = "buttonCinq";
            this.buttonCinq.Size = new System.Drawing.Size(67, 60);
            this.buttonCinq.TabIndex = 11;
            this.buttonCinq.Text = "5";
            this.buttonCinq.UseVisualStyleBackColor = false;
            this.buttonCinq.Click += new System.EventHandler(this.button_click);
            // 
            // buttonUn
            // 
            this.buttonUn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonUn.BackColor = System.Drawing.Color.White;
            this.buttonUn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUn.Location = new System.Drawing.Point(2, 265);
            this.buttonUn.Name = "buttonUn";
            this.buttonUn.Size = new System.Drawing.Size(67, 60);
            this.buttonUn.TabIndex = 12;
            this.buttonUn.Text = "1";
            this.buttonUn.UseVisualStyleBackColor = false;
            this.buttonUn.Click += new System.EventHandler(this.button_click);
            // 
            // buttonTrois
            // 
            this.buttonTrois.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonTrois.BackColor = System.Drawing.Color.White;
            this.buttonTrois.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrois.Location = new System.Drawing.Point(134, 265);
            this.buttonTrois.Name = "buttonTrois";
            this.buttonTrois.Size = new System.Drawing.Size(67, 60);
            this.buttonTrois.TabIndex = 14;
            this.buttonTrois.Text = "3";
            this.buttonTrois.UseVisualStyleBackColor = false;
            this.buttonTrois.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDeux
            // 
            this.buttonDeux.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDeux.BackColor = System.Drawing.Color.White;
            this.buttonDeux.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeux.Location = new System.Drawing.Point(68, 265);
            this.buttonDeux.Name = "buttonDeux";
            this.buttonDeux.Size = new System.Drawing.Size(67, 60);
            this.buttonDeux.TabIndex = 15;
            this.buttonDeux.Text = "2";
            this.buttonDeux.UseVisualStyleBackColor = false;
            this.buttonDeux.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEgale
            // 
            this.buttonEgale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonEgale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEgale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEgale.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.buttonEgale.Location = new System.Drawing.Point(203, 325);
            this.buttonEgale.Name = "buttonEgale";
            this.buttonEgale.Size = new System.Drawing.Size(63, 59);
            this.buttonEgale.TabIndex = 17;
            this.buttonEgale.Text = "=";
            this.buttonEgale.UseVisualStyleBackColor = false;
            this.buttonEgale.Click += new System.EventHandler(this.Egale_click);
            // 
            // buttonVirgule
            // 
            this.buttonVirgule.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonVirgule.BackColor = System.Drawing.Color.White;
            this.buttonVirgule.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgule.Location = new System.Drawing.Point(134, 324);
            this.buttonVirgule.Name = "buttonVirgule";
            this.buttonVirgule.Size = new System.Drawing.Size(67, 60);
            this.buttonVirgule.TabIndex = 18;
            this.buttonVirgule.Text = ",";
            this.buttonVirgule.UseVisualStyleBackColor = false;
            this.buttonVirgule.Click += new System.EventHandler(this.button_click);
            // 
            // buttonZéro
            // 
            this.buttonZéro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonZéro.BackColor = System.Drawing.Color.White;
            this.buttonZéro.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZéro.Location = new System.Drawing.Point(68, 324);
            this.buttonZéro.Name = "buttonZéro";
            this.buttonZéro.Size = new System.Drawing.Size(67, 60);
            this.buttonZéro.TabIndex = 19;
            this.buttonZéro.Text = "0";
            this.buttonZéro.UseVisualStyleBackColor = false;
            this.buttonZéro.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonDivision.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(2, 85);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(67, 60);
            this.buttonDivision.TabIndex = 1;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonMultiplication.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.buttonMultiplication.Location = new System.Drawing.Point(200, 265);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(67, 60);
            this.buttonMultiplication.TabIndex = 13;
            this.buttonMultiplication.Text = "+";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.operateur_click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonMoins.BackColor = System.Drawing.Color.White;
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.Location = new System.Drawing.Point(2, 324);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(67, 60);
            this.buttonMoins.TabIndex = 20;
            this.buttonMoins.Text = "+/-";
            this.buttonMoins.UseVisualStyleBackColor = false;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonReturn.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReturn.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonReturn.Location = new System.Drawing.Point(200, 85);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 60);
            this.buttonReturn.TabIndex = 21;
            this.buttonReturn.Text = "";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(210, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 21);
            this.label.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(267, 387);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.ResultatText);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonZéro);
            this.Controls.Add(this.buttonSept);
            this.Controls.Add(this.buttonVirgule);
            this.Controls.Add(this.buttonProduit);
            this.Controls.Add(this.buttonEgale);
            this.Controls.Add(this.buttonNeuf);
            this.Controls.Add(this.buttonDeux);
            this.Controls.Add(this.buttonHuit);
            this.Controls.Add(this.buttonTrois);
            this.Controls.Add(this.buttonQuatre);
            this.Controls.Add(this.buttonUn);
            this.Controls.Add(this.buttonSoustraction);
            this.Controls.Add(this.buttonCinq);
            this.Controls.Add(this.buttonSix);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ResultatText;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonSept;
        private System.Windows.Forms.Button buttonProduit;
        private System.Windows.Forms.Button buttonNeuf;
        private System.Windows.Forms.Button buttonHuit;
        private System.Windows.Forms.Button buttonQuatre;
        private System.Windows.Forms.Button buttonSoustraction;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonCinq;
        private System.Windows.Forms.Button buttonUn;
        private System.Windows.Forms.Button buttonTrois;
        private System.Windows.Forms.Button buttonDeux;
        private System.Windows.Forms.Button buttonEgale;
        private System.Windows.Forms.Button buttonVirgule;
        private System.Windows.Forms.Button buttonZéro;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label;
    }
}

