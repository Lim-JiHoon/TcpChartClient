namespace TcpChatClient
{
  partial class ClientForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnSendMessage = new System.Windows.Forms.Button();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtIp = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnConnect = new System.Windows.Forms.Button();
      this.txtNickName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.txtChat = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // btnSendMessage
      // 
      this.btnSendMessage.Location = new System.Drawing.Point(339, 415);
      this.btnSendMessage.Name = "btnSendMessage";
      this.btnSendMessage.Size = new System.Drawing.Size(108, 23);
      this.btnSendMessage.TabIndex = 1;
      this.btnSendMessage.Text = "메세지 전송";
      this.btnSendMessage.UseVisualStyleBackColor = true;
      this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(177, 6);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(45, 23);
      this.txtPort.TabIndex = 10;
      this.txtPort.Text = "8080";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(142, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 15);
      this.label2.TabIndex = 9;
      this.label2.Text = "Port";
      // 
      // txtIp
      // 
      this.txtIp.Location = new System.Drawing.Point(68, 6);
      this.txtIp.Name = "txtIp";
      this.txtIp.Size = new System.Drawing.Size(68, 23);
      this.txtIp.TabIndex = 8;
      this.txtIp.Text = "127.0.0.1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 15);
      this.label1.TabIndex = 7;
      this.label1.Text = "ServerIP";
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(339, 6);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(107, 23);
      this.btnConnect.TabIndex = 6;
      this.btnConnect.Text = "클라이언트 연결";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // txtNickName
      // 
      this.txtNickName.Location = new System.Drawing.Point(277, 6);
      this.txtNickName.Name = "txtNickName";
      this.txtNickName.Size = new System.Drawing.Size(56, 23);
      this.txtNickName.TabIndex = 12;
      this.txtNickName.Text = "까불이";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(228, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 15);
      this.label3.TabIndex = 11;
      this.label3.Text = "닉네임";
      // 
      // txtMessage
      // 
      this.txtMessage.Location = new System.Drawing.Point(12, 415);
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Size = new System.Drawing.Size(321, 23);
      this.txtMessage.TabIndex = 13;
      this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
      // 
      // txtChat
      // 
      this.txtChat.Location = new System.Drawing.Point(12, 35);
      this.txtChat.Name = "txtChat";
      this.txtChat.Size = new System.Drawing.Size(435, 374);
      this.txtChat.TabIndex = 14;
      this.txtChat.Text = "";
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(460, 450);
      this.Controls.Add(this.txtChat);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.txtNickName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtIp);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.btnSendMessage);
      this.Name = "ClientForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Button btnSendMessage;
    private TextBox txtPort;
    private Label label2;
    private TextBox txtIp;
    private Label label1;
    private Button btnConnect;
    private TextBox txtNickName;
    private Label label3;
    private TextBox txtMessage;
    private RichTextBox txtChat;
  }
}