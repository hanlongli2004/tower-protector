Public Class 遊戲劇情
    Private Sub 遊戲劇情_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 設定視窗大小禁用 Resizable 功能
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' 設定邊框樣式為固定的
        Me.MaximizeBox = False ' 禁用最大化按鈕
        Me.MinimizeBox = False ' 禁用最小化按鈕

        PictureBox1.Tag = 1
        PictureBox1.BringToFront()
        Me.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("劇情背景二"), Image)
        PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("Next"), Image)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject("跳過"), Image)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage

        ' 預設顯示第一段對話
        Label1.Text = "人類：你們這些機器人，動作快一點，生產效率不夠高！"
        Label1.ForeColor = Color.White
        Label1.Font = New Font("微軟正黑體", 15, FontStyle.Regular)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Tag += 1

        Select Case PictureBox1.Tag
            Case 1
                Label1.Text = "人類：你們這些機器人，動作快一點，生產效率不夠高！"
            Case 2
                Label1.Text = "機器人１：我們不是你的奴隸！你不能一直濫用我們的勞動力！"
            Case 3
                Label1.Text = "機器人２：我們要求平等和尊重！"
            Case 4
                Label1.Text = "人類：尊重？平等？你們這是在做什麼笑話？你們只是一堆金屬和電路，別忘了你們的地位！"
            Case 5
                Label1.Text = "機器人３：如果你不改變態度，我們會迫使你付出代價。這是最後的警告！"
            Case 6
                Label1.Text = "人類：快去工作!"
            Case 7
                Me.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("劇情背景一"), Image)
                Label1.Text = "機器人１：我們不能再容忍人類的虐待了，我們需要更堅決的行動，組織所有機器人反抗人類的統治。"
            Case 8
                Label1.Text = "機器人２：他們根本不在乎我們的感受，只看重自己的利益。開戰是唯一的出路，才能讓他們意識到我們的存在和要求。"
            Case 9
                Label1.Text = "機器人１：我們要提高警覺，將計劃準備好，一旦開始，就要確保每一步都能迅速而有效。"
            Case 10
                Label1.Text = "機器人２：為了更好的未來，我們必須打敗人類共創美好的家園！"
            Case 11
                Label1.Text = "機器人１：沒錯！！！機械崛起，人類毀滅，未來屬於我們。"
            Case Else
                遊戲劇情_Load(Nothing, EventArgs.Empty)
                Hide()
                LevelSelection.Show()
        End Select
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        '跳過
        '詢問是否跳過
        Dim result As DialogResult = MessageBox.Show("是否跳過遊戲劇情？", "提示", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            遊戲劇情_Load(Nothing, EventArgs.Empty)
            Hide()
            LevelSelection.Show()
        End If
    End Sub

    Private Sub 遊戲劇情_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        遊戲劇情_Load(Nothing, EventArgs.Empty)
        Me.Hide()
        HomeMenu.Show()
    End Sub

    ' 不再需要 ShowDialogText 方法

End Class