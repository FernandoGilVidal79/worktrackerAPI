﻿
namespace WorkTrackerAPP
{
    partial class Fichar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fichar));
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnJornada = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblFichajeActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDescanso
            // 
            this.btnDescanso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescanso.Image = ((System.Drawing.Image)(resources.GetObject("btnDescanso.Image")));
            this.btnDescanso.Location = new System.Drawing.Point(73, 348);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(269, 64);
            this.btnDescanso.TabIndex = 44;
            this.btnDescanso.Text = "Descanso";
            this.btnDescanso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescanso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Image = ((System.Drawing.Image)(resources.GetObject("btnComida.Image")));
            this.btnComida.Location = new System.Drawing.Point(73, 258);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(269, 67);
            this.btnComida.TabIndex = 43;
            this.btnComida.Text = "Comida";
            this.btnComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(363, 33);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(210, 20);
            this.lblResumen.TabIndex = 41;
            this.lblResumen.Text = "Resumen de la semana";
            // 
            // btnJornada
            // 
            this.btnJornada.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJornada.Image = ((System.Drawing.Image)(resources.GetObject("btnJornada.Image")));
            this.btnJornada.Location = new System.Drawing.Point(73, 178);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(269, 65);
            this.btnJornada.TabIndex = 42;
            this.btnJornada.Text = "Entrada";
            this.btnJornada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJornada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJornada.UseVisualStyleBackColor = true;
            this.btnJornada.Click += new System.EventHandler(this.btnJornada_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(461, 103);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(0, 20);
            this.lblHistorico.TabIndex = 45;
            // 
            // lblFichajeActual
            // 
            this.lblFichajeActual.AutoSize = true;
            this.lblFichajeActual.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichajeActual.Location = new System.Drawing.Point(363, 77);
            this.lblFichajeActual.Name = "lblFichajeActual";
            this.lblFichajeActual.Size = new System.Drawing.Size(0, 20);
            this.lblFichajeActual.TabIndex = 46;
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1185, 684);
            this.Controls.Add(this.lblFichajeActual);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.btnDescanso);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnJornada);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblFichajeActual;
    }
}