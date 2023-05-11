
namespace Lab10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_team = new System.Windows.Forms.DataGridView();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lambda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.pos1 = new System.Windows.Forms.Label();
            this.pos2 = new System.Windows.Forms.Label();
            this.pos4 = new System.Windows.Forms.Label();
            this.pos3 = new System.Windows.Forms.Label();
            this.pos5 = new System.Windows.Forms.Label();
            this.pos6 = new System.Windows.Forms.Label();
            this.pos7 = new System.Windows.Forms.Label();
            this.pos8 = new System.Windows.Forms.Label();
            this.pos12 = new System.Windows.Forms.Label();
            this.pos56 = new System.Windows.Forms.Label();
            this.pos34 = new System.Windows.Forms.Label();
            this.pos78 = new System.Windows.Forms.Label();
            this.pos13 = new System.Windows.Forms.Label();
            this.pos57 = new System.Windows.Forms.Label();
            this.pos15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_team)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_team
            // 
            this.grid_team.AllowUserToAddRows = false;
            this.grid_team.AllowUserToDeleteRows = false;
            this.grid_team.AllowUserToResizeColumns = false;
            this.grid_team.AllowUserToResizeRows = false;
            this.grid_team.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_team.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Party,
            this.Lambda});
            this.grid_team.Location = new System.Drawing.Point(12, 12);
            this.grid_team.Name = "grid_team";
            this.grid_team.RowHeadersVisible = false;
            this.grid_team.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_team.RowTemplate.Height = 24;
            this.grid_team.Size = new System.Drawing.Size(287, 505);
            this.grid_team.TabIndex = 0;
            // 
            // Party
            // 
            this.Party.HeaderText = "Team";
            this.Party.MinimumWidth = 6;
            this.Party.Name = "Party";
            // 
            // Lambda
            // 
            this.Lambda.HeaderText = "WinningProbability";
            this.Lambda.MinimumWidth = 6;
            this.Lambda.Name = "Lambda";
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(12, 523);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(287, 67);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Let\'s generate teams!";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 596);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(287, 67);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pos1
            // 
            this.pos1.AutoSize = true;
            this.pos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos1.Location = new System.Drawing.Point(349, 12);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(0, 25);
            this.pos1.TabIndex = 3;
            // 
            // pos2
            // 
            this.pos2.AutoSize = true;
            this.pos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos2.Location = new System.Drawing.Point(349, 143);
            this.pos2.Name = "pos2";
            this.pos2.Size = new System.Drawing.Size(0, 25);
            this.pos2.TabIndex = 4;
            // 
            // pos4
            // 
            this.pos4.AutoSize = true;
            this.pos4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos4.Location = new System.Drawing.Point(349, 492);
            this.pos4.Name = "pos4";
            this.pos4.Size = new System.Drawing.Size(0, 25);
            this.pos4.TabIndex = 5;
            // 
            // pos3
            // 
            this.pos3.AutoSize = true;
            this.pos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos3.Location = new System.Drawing.Point(349, 317);
            this.pos3.Name = "pos3";
            this.pos3.Size = new System.Drawing.Size(0, 25);
            this.pos3.TabIndex = 6;
            // 
            // pos5
            // 
            this.pos5.AutoSize = true;
            this.pos5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos5.Location = new System.Drawing.Point(1282, 12);
            this.pos5.Name = "pos5";
            this.pos5.Size = new System.Drawing.Size(0, 25);
            this.pos5.TabIndex = 7;
            // 
            // pos6
            // 
            this.pos6.AutoSize = true;
            this.pos6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos6.Location = new System.Drawing.Point(1282, 134);
            this.pos6.Name = "pos6";
            this.pos6.Size = new System.Drawing.Size(0, 25);
            this.pos6.TabIndex = 8;
            // 
            // pos7
            // 
            this.pos7.AutoSize = true;
            this.pos7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos7.Location = new System.Drawing.Point(1282, 317);
            this.pos7.Name = "pos7";
            this.pos7.Size = new System.Drawing.Size(0, 25);
            this.pos7.TabIndex = 9;
            // 
            // pos8
            // 
            this.pos8.AutoSize = true;
            this.pos8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos8.Location = new System.Drawing.Point(1282, 492);
            this.pos8.Name = "pos8";
            this.pos8.Size = new System.Drawing.Size(0, 25);
            this.pos8.TabIndex = 10;
            // 
            // pos12
            // 
            this.pos12.AutoSize = true;
            this.pos12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos12.Location = new System.Drawing.Point(566, 76);
            this.pos12.Name = "pos12";
            this.pos12.Size = new System.Drawing.Size(0, 25);
            this.pos12.TabIndex = 11;
            // 
            // pos56
            // 
            this.pos56.AutoSize = true;
            this.pos56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos56.Location = new System.Drawing.Point(1104, 76);
            this.pos56.Name = "pos56";
            this.pos56.Size = new System.Drawing.Size(0, 25);
            this.pos56.TabIndex = 12;
            // 
            // pos34
            // 
            this.pos34.AutoSize = true;
            this.pos34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos34.Location = new System.Drawing.Point(566, 403);
            this.pos34.Name = "pos34";
            this.pos34.Size = new System.Drawing.Size(0, 25);
            this.pos34.TabIndex = 13;
            // 
            // pos78
            // 
            this.pos78.AutoSize = true;
            this.pos78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos78.Location = new System.Drawing.Point(1104, 403);
            this.pos78.Name = "pos78";
            this.pos78.Size = new System.Drawing.Size(0, 25);
            this.pos78.TabIndex = 14;
            // 
            // pos13
            // 
            this.pos13.AutoSize = true;
            this.pos13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos13.Location = new System.Drawing.Point(726, 242);
            this.pos13.Name = "pos13";
            this.pos13.Size = new System.Drawing.Size(0, 25);
            this.pos13.TabIndex = 15;
            // 
            // pos57
            // 
            this.pos57.AutoSize = true;
            this.pos57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos57.Location = new System.Drawing.Point(924, 242);
            this.pos57.Name = "pos57";
            this.pos57.Size = new System.Drawing.Size(0, 25);
            this.pos57.TabIndex = 16;
            // 
            // pos15
            // 
            this.pos15.AutoSize = true;
            this.pos15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos15.Location = new System.Drawing.Point(824, 12);
            this.pos15.Name = "pos15";
            this.pos15.Size = new System.Drawing.Size(75, 25);
            this.pos15.TabIndex = 17;
            this.pos15.Text = "Winner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 691);
            this.Controls.Add(this.pos15);
            this.Controls.Add(this.pos57);
            this.Controls.Add(this.pos13);
            this.Controls.Add(this.pos78);
            this.Controls.Add(this.pos34);
            this.Controls.Add(this.pos56);
            this.Controls.Add(this.pos12);
            this.Controls.Add(this.pos8);
            this.Controls.Add(this.pos7);
            this.Controls.Add(this.pos6);
            this.Controls.Add(this.pos5);
            this.Controls.Add(this.pos3);
            this.Controls.Add(this.pos4);
            this.Controls.Add(this.pos2);
            this.Controls.Add(this.pos1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.grid_team);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.grid_team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_team;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label pos1;
        private System.Windows.Forms.Label pos2;
        private System.Windows.Forms.Label pos4;
        private System.Windows.Forms.Label pos3;
        private System.Windows.Forms.Label pos5;
        private System.Windows.Forms.Label pos6;
        private System.Windows.Forms.Label pos7;
        private System.Windows.Forms.Label pos8;
        private System.Windows.Forms.Label pos12;
        private System.Windows.Forms.Label pos56;
        private System.Windows.Forms.Label pos34;
        private System.Windows.Forms.Label pos78;
        private System.Windows.Forms.Label pos13;
        private System.Windows.Forms.Label pos57;
        private System.Windows.Forms.Label pos15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lambda;
    }
}

