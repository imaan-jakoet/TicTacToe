namespace TicTacToe.Presentation
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
            player1ListBox = new ListBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button0 = new Button();
            player1TextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            player2TextBox = new TextBox();
            player2ListBox = new ListBox();
            label4 = new Label();
            name1Label = new Label();
            name2Label = new Label();
            newRoundButton = new Button();
            newGameButton = new Button();
            startButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // player1ListBox
            // 
            player1ListBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1ListBox.FormattingEnabled = true;
            player1ListBox.Location = new Point(976, 547);
            player1ListBox.Name = "player1ListBox";
            player1ListBox.Size = new Size(150, 104);
            player1ListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 69);
            label1.Name = "label1";
            label1.Size = new Size(516, 83);
            label1.TabIndex = 1;
            label1.Text = "TIC TAC TOE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button0, 0, 0);
            tableLayoutPanel1.Location = new Point(83, 203);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(587, 501);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button8
            // 
            button8.Location = new Point(393, 337);
            button8.Name = "button8";
            button8.Size = new Size(189, 161);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(198, 337);
            button7.Name = "button7";
            button7.Size = new Size(189, 161);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 337);
            button6.Name = "button6";
            button6.Size = new Size(189, 161);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(393, 170);
            button5.Name = "button5";
            button5.Size = new Size(189, 161);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(198, 170);
            button4.Name = "button4";
            button4.Size = new Size(189, 161);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 170);
            button3.Name = "button3";
            button3.Size = new Size(189, 161);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(393, 3);
            button2.Name = "button2";
            button2.Size = new Size(189, 161);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(198, 3);
            button1.Name = "button1";
            button1.Size = new Size(189, 161);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button0
            // 
            button0.Location = new Point(3, 3);
            button0.Name = "button0";
            button0.Size = new Size(189, 161);
            button0.TabIndex = 0;
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // player1TextBox
            // 
            player1TextBox.Location = new Point(1182, 219);
            player1TextBox.Name = "player1TextBox";
            player1TextBox.Size = new Size(449, 27);
            player1TextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(855, 216);
            label2.Name = "label2";
            label2.Size = new Size(273, 30);
            label2.TabIndex = 4;
            label2.Text = "Enter Player 1's Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(855, 289);
            label3.Name = "label3";
            label3.Size = new Size(273, 30);
            label3.TabIndex = 5;
            label3.Text = "Enter Player 2's Name:";
            // 
            // player2TextBox
            // 
            player2TextBox.Location = new Point(1182, 289);
            player2TextBox.Name = "player2TextBox";
            player2TextBox.Size = new Size(449, 27);
            player2TextBox.TabIndex = 6;
            // 
            // player2ListBox
            // 
            player2ListBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2ListBox.FormattingEnabled = true;
            player2ListBox.Location = new Point(1373, 547);
            player2ListBox.Name = "player2ListBox";
            player2ListBox.Size = new Size(150, 104);
            player2ListBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1085, 422);
            label4.Name = "label4";
            label4.Size = new Size(290, 41);
            label4.TabIndex = 8;
            label4.Text = "SCOREBOARD";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // name1Label
            // 
            name1Label.AutoSize = true;
            name1Label.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name1Label.Location = new Point(884, 475);
            name1Label.Name = "name1Label";
            name1Label.Size = new Size(0, 34);
            name1Label.TabIndex = 9;
            name1Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // name2Label
            // 
            name2Label.AutoSize = true;
            name2Label.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name2Label.Location = new Point(1354, 475);
            name2Label.Name = "name2Label";
            name2Label.Size = new Size(0, 34);
            name2Label.TabIndex = 10;
            name2Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // newRoundButton
            // 
            newRoundButton.BackColor = SystemColors.ActiveCaption;
            newRoundButton.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            newRoundButton.Location = new Point(897, 745);
            newRoundButton.Name = "newRoundButton";
            newRoundButton.Size = new Size(229, 97);
            newRoundButton.TabIndex = 11;
            newRoundButton.Text = "New Round";
            newRoundButton.UseVisualStyleBackColor = false;
            newRoundButton.Click += newRoundButton_Click_1;
            // 
            // newGameButton
            // 
            newGameButton.BackColor = SystemColors.ActiveCaption;
            newGameButton.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            newGameButton.Location = new Point(1294, 745);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(229, 97);
            newGameButton.TabIndex = 12;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = false;
            newGameButton.Click += newGameButton_Click_1;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.ActiveCaption;
            startButton.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startButton.Location = new Point(1105, 344);
            startButton.Name = "startButton";
            startButton.Size = new Size(222, 57);
            startButton.TabIndex = 13;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 854);
            Controls.Add(startButton);
            Controls.Add(newGameButton);
            Controls.Add(newRoundButton);
            Controls.Add(name2Label);
            Controls.Add(name1Label);
            Controls.Add(label4);
            Controls.Add(player2ListBox);
            Controls.Add(player2TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(player1TextBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(player1ListBox);
            Name = "Form1";
            Text = "TicTacToe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox player1ListBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button0;
        private TextBox player1TextBox;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox player2TextBox;
        private ListBox player2ListBox;
        private Label label4;
        private Label name1Label;
        private Label name2Label;
        private Button newRoundButton;
        private Button newGameButton;
        private Button startButton;
    }
}