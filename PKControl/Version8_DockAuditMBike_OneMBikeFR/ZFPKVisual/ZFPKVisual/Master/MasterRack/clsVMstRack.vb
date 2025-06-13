'Server=WINDOWS-9FQLVMQ;uid=sa;pwd=abc123!;Database=PCS_TEST
'admin@Tom!@#123

Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstRack
    Private cls As New clsCMstRack
    Private fNew As Boolean = False
    Private mRow As Integer = 0
    Private mRackHDID As Integer = 0

    Private iFront As Integer = SystemINI.ModelTypeMB.Front
    Private iRear As Integer = SystemINI.ModelTypeMB.Rear

#Region "Load"

    Private Sub clsVMstRack_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstRack_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        LoadForm()
    End Sub
    Private Sub LoadForm()
        With cboSType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .LinkCheckedBox = chkSType
        End With
        With cboSModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            If CustomerCode = "MB" Then
                .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0", , , , , , "Model")
            Else
                .DataSource = DataBase.DataSelect("MstModel" _
                                                  , "DelFlag=0" _
                                                  , , _
                                                  , "ID " & _
                                                    ",case when Model=ModelContainer then Model else Model + ' (' + ModelContainer + ')' end as Model" & _
                                                    ",FrontFlag,RearFlag,FrontRearFlag,STBFlag,MBikeFlag" & _
                                                    ",ColorA,ColorR,ColorG,ColorB" & _
                                                    ",ModelContainer,ModelContainerSeq,PTCFlag" & _
                                                    ",DelFlag" & _
                                                    ",CreateUser,CreateDate,UpdateUser,UpdateDate" _
                                                  , , _
                                                  , "Model")
            End If
            .LinkCheckedBox = chkSModel
        End With
        With cboSCode
            .ValueMember = "Code"
            .DisplayMember = "Code"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Code", , , "Code")
            .LinkCheckedBox = chkSCode
        End With
        With cboSRemark
            .ValueMember = "Remark"
            .DisplayMember = "Remark"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Remark", , , "Remark")
            .LinkCheckedBox = chkSRemark
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstRackHD")
        ComboSet.TextString(txtCode, dtLength, "Code")
        ComboSet.TextString(txtRemark, dtLength, "Remark")
        ComboSet.TextString(txtInitialNo, dtLength, "InitialNo")
        ComboSet.TextString(txtEndNo, dtLength, "EndNo")
        ComboSet.TextString(txtInitialRackID, dtLength, "InitialRackID")
        ComboSet.TextString(txtEndRackID, dtLength, "EndRackID")

        Dim dt As DataTable = cls.GetData(False, 0, True, 0, False, "", False, "")
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        grpUpdateData.Visible = False
        btnSave.Enabled = False
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("RackHeaderID", "RackHeaderID", "RackHeaderID", , , , , False)
            .ColumnAdd_TextBox("TypeName", "Type", "TypeName", 120)
            .ColumnAdd_TextBox("Model", "Model", "Model", 120)
            .ColumnAdd_TextBox("Code", "Code", "Code", 120)
            .ColumnAdd_TextBox("Remark", "Remark", "Remark")
            .ColumnAdd_TextBox("Qty", "Qty", "Qty", , , DataGridViewContentAlignment.MiddleRight)
            .ColumnAdd_TextBox("InitialNo", "Initial", "InitialNo", 120)
            .ColumnAdd_TextBox("EndNo", "End", "EndNo", 120)
            .ColumnAdd_Button("Rack", "Rack Number", , , , "...", DataGridViewContentAlignment.MiddleCenter)
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
        'ComboSet.GridColumnSize(grdData)
    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
        If grdData.DataSource Is Nothing Or grdData.SelectedRow Is Nothing Then Exit Sub
        If e.ColumnIndex <> grdData.Columns("Rack").Index Then Exit Sub

        Dim RackHDID As Integer = Converts.ToInt_NullIsZero(grdData.SelectedRow("RackHeaderID"))
        If RackHDID = 0 OrElse grdData.SelectedRow("sta") <> "" Then
            MessageBox.Show("Please save this record, first")
        Else
            Dim frm As New clsVMstRackDT
            With frm
                .RowRackHD = grdData.SelectedRow
                If .ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    grdData.SelectedRow("Qty") = Converts.ToInt_NullIsZero(frm.txtQty.Text.Trim)
                End If
            End With
        End If

    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        If CheckUpdateData() = False Then Exit Sub

        Dim dt As DataTable = cls.GetData(chkSType.Checked, cboSType.SelectedValue _
                                          , chkSModel.Checked, cboSModel.SelectedValue _
                                          , chkSCode.Checked, cboSCode.SelectedValue _
                                          , chkSRemark.Checked, cboSRemark.SelectedValue)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv
    End Sub

    Private Sub btnSearch_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkSType.Checked AndAlso cboSType.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSType, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If chkSModel.Checked AndAlso cboSModel.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSModel, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If chkSCode.Checked AndAlso cboSCode.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSCode, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If chkSRemark.Checked AndAlso cboSRemark.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSRemark, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtRackHD As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If Not (dr("sta") = "D" And Converts.ToInt_NullIsZero(dr("RackHeaderID")) = 0) Then
                dtRackHD.ImportRow(dr)
            End If
        Next

        Dim dtNew As DataTable = cls.SaveData(dtRackHD)
        If Not dtNew Is Nothing Then
            dv = New DataView(dtNew, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dv

            grpUpdateData.Visible = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        cboType.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing OrElse grdData.CurrentRow Is Nothing Then Exit Sub

        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        cboType.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        With cboType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .Enabled = True
            .SelectedIndex = 0
        End With
        'With cboModel
        '    .ValueMember = "ID"
        '    .DisplayMember = "Model"
        '    .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0")
        '    .Enabled = True
        '    .SelectedIndex = -1
        'End With

        mRackHDID = 0
        With txtCode
            .Clear()
            .ReadOnly = False
        End With
        With txtRemark
            .Clear()
            .ReadOnly = False
        End With
        txtQty.Clear()
        With txtInitialNo
            .Clear()
            .ReadOnly = False
        End With
        With txtEndNo
            .Clear()
            .ReadOnly = False
        End With
        With txtInitialRackID
            .Clear()
            .ReadOnly = False
        End With
        With txtEndRackID
            .Clear()
            .ReadOnly = False
        End With
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex

        ClearControlDetail()

        mRackHDID = rGrid("RackHeaderID")
        cboType.SelectedValue = rGrid("Type")
        cboModel.SelectedValue = rGrid("ModelID")
        txtCode.Text = Converts.ToStr(rGrid("Code"))
        txtRemark.Text = Converts.ToStr(rGrid("Remark"))
        txtQty.Text = Converts.ToInt_NullIsZero(rGrid("Qty"))
        txtInitialNo.Text = Converts.ToStr(rGrid("InitialNo"))
        txtEndNo.Text = Converts.ToStr(rGrid("EndNo"))
        txtInitialRackID.Text = Converts.ToStr(rGrid("InitialRackID"))
        txtEndRackID.Text = Converts.ToStr(rGrid("EndRackID"))

        Dim fEditAble As Boolean = (Converts.ToInt_NullIsZero(rGrid("DetailFlag")) = 0)
        cboType.Enabled = fEditAble
        cboModel.Enabled = fEditAble
        txtCode.ReadOnly = Not (fEditAble)
        txtRemark.ReadOnly = Not (fEditAble)
        txtInitialNo.ReadOnly = Not (fEditAble)
        txtEndNo.ReadOnly = Not (fEditAble)
        txtInitialRackID.ReadOnly = Not (fEditAble)
        txtEndRackID.ReadOnly = Not (fEditAble)
    End Sub
#End Region

#Region "Data to Grid"
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If OKValidate() = False Then Exit Sub

        DataToGrid()

        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False
        fNew = False
        mRow = 0

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Function OKValidate() As Boolean
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If cboType.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboType, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If cboModel.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If cboType.SelectedIndex >= 0 And cboModel.SelectedIndex >= 0 Then
            Dim iType As Integer = cboType.SelectedValue
            Dim drModel As DataRow = cboModel.SelectedRow
            Select Case iType
                Case iFront
                    If Converts.ToInt_NullIsZero(drModel("FrontFlag")) = 0 Then
                        bTrue = bTrue And Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.None, "This model not support front")
                    End If
                Case iRear
                    If Converts.ToInt_NullIsZero(drModel("RearFlag")) = 0 Then
                        bTrue = bTrue And Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.None, "This model not support rear")
                    End If
            End Select
        End If

        If txtInitialNo.Text.Trim.Length <> txtEndNo.Text.Trim.Length Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtInitialNo, OPE_Controls.MessageType.InvalidFormat)
            bTrue = bTrue And Messages.SetError(ErrProvider, txtEndNo, OPE_Controls.MessageType.InvalidFormat)
        Else
            If cboType.SelectedIndex >= 0 And cboModel.SelectedIndex >= 0 And txtInitialNo.Text.Trim <> "" And txtEndNo.Text.Trim <> "" Then
                Dim iniPrefix As String = ""
                Dim EndPrefix As String = ""
                Dim iniRunDigit As Integer = 0
                Dim EndRunDigit As Integer = 0
                For i As Integer = txtInitialNo.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtInitialNo.Text.Trim, i)) = True Then
                        iniPrefix = Strings.Left(txtInitialNo.Text.Trim, txtInitialNo.Text.Trim.Length - i)
                        iniRunDigit = i
                        Exit For
                    End If
                Next
                For i As Integer = txtEndNo.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtEndNo.Text.Trim, i)) = True Then
                        EndPrefix = Strings.Left(txtEndNo.Text.Trim, txtEndNo.Text.Trim.Length - i)
                        EndRunDigit = i
                        Exit For
                    End If
                Next

                If iniPrefix <> EndPrefix Or iniPrefix = "" Or EndPrefix = "" Or iniRunDigit = 0 Or EndRunDigit = 0 Then
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtInitialNo, OPE_Controls.MessageType.InvalidFormat)
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtEndNo, OPE_Controls.MessageType.InvalidFormat)
                Else
                    Dim nIni As Integer = Converts.ToInt_NullIsZero(Strings.Right(txtInitialNo.Text.Trim, iniRunDigit))
                    Dim nEnd As Integer = Converts.ToInt_NullIsZero(Strings.Right(txtEndNo.Text.Trim, EndRunDigit))
                    Dim iModel As Integer = cboModel.SelectedValue
                    Dim iType As Integer = cboType.SelectedValue
                    Dim sCode As String = txtCode.Text.Trim
                    Dim sRemark As String = txtRemark.Text.Trim
                    If nIni > 0 And nEnd > 0 And sCode <> "" Then
                        Dim dv As DataView = grdData.DataSource
                        Dim dt As DataTable = dv.ToTable
                        Dim fDuplicate As Boolean = False

                        Dim nRec As Integer = 0
                        '=================Check duplicate with grid
                        If fNew = True Then
                            nRec = dt.Compute("count(RackHeaderID)", "ModelID=" & iModel & " and Code='" & sCode & "' and Type=" & iType & " and Remark='" & sRemark & "'")
                        Else
                            nRec = dt.Compute("count(RackHeaderID)", "RackHeaderID<>" & mRackHDID & " and ModelID=" & iModel & " and Code='" & sCode & "' and Type=" & iType & " and Remark='" & sRemark & "'")
                        End If
                        If nRec > 0 Then
                            If CustomizeSetting.CustomerCode = "MB" Then
                                For Each dr As DataRow In dt.Select("ModelID=" & iModel & " and Code='" & sCode & "' and Type=" & cboType.SelectedValue & " and Remark='" & txtRemark.Text.Trim & "'")
                                    If nIni >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nIni <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                        fDuplicate = True
                                    ElseIf nEnd >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nEnd <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                        fDuplicate = True
                                    End If
                                Next
                            Else
                                For Each dr As DataRow In dt.Select("ModelID=" & iModel & " and Code='" & sCode & "' and Type=" & cboType.SelectedValue & " and Remark='" & txtRemark.Text.Trim & "'")
                                    If Strings.Left(dr("InitialNo"), iniPrefix.Length) = iniPrefix Then
                                        If nIni >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nIni <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                            fDuplicate = True
                                        ElseIf nEnd >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nEnd <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                            fDuplicate = True
                                        End If
                                    End If
                                Next
                            End If
                        End If
                        '=================Check duplicate with DB
                        dt = DataBase.DataSelect("MstRackHD", "DelFlag=0 and RackHeaderID<>" & mRackHDID & " and ModelID=" & iModel & " and Code='" & sCode & "' and Type=" & iType & " and Remark='" & sRemark & "' and left(InitialNo," & iniPrefix.Length & ")='" & iniPrefix & "'")
                        For Each dr As DataRow In dt.Select()
                            If nIni >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nIni <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                fDuplicate = True
                            ElseIf nEnd >= Converts.ToInt_NullIsZero(Strings.Right(dr("InitialNo"), iniRunDigit)) And nEnd <= Converts.ToInt_NullIsZero(Strings.Right(dr("EndNo"), iniRunDigit)) Then
                                fDuplicate = True
                            End If
                        Next
                        '===========================================
                        If fDuplicate = True Then
                            bTrue = bTrue And Messages.SetError(ErrProvider, txtInitialNo, OPE_Controls.MessageType.DataExistPleaseChange)
                            bTrue = bTrue And Messages.SetError(ErrProvider, txtEndNo, OPE_Controls.MessageType.DataExistPleaseChange)
                        End If
                    End If
                End If
            End If
        End If

        If txtInitialRackID.Text.Trim <> "" Or txtEndRackID.Text.Trim <> "" Then
            If txtInitialRackID.Text.Trim.Length <> txtEndRackID.Text.Trim.Length Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtInitialRackID, OPE_Controls.MessageType.InvalidFormat)
                bTrue = bTrue And Messages.SetError(ErrProvider, txtEndRackID, OPE_Controls.MessageType.InvalidFormat)
            Else
                Dim iniPrefix As String = ""
                Dim EndPrefix As String = ""
                Dim iniRunDigit As Integer = 0
                Dim EndRunDigit As Integer = 0
                For i As Integer = txtInitialRackID.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtInitialRackID.Text.Trim, i)) = True Then
                        iniPrefix = Strings.Left(txtInitialRackID.Text.Trim, txtInitialRackID.Text.Trim.Length - i)
                        iniRunDigit = i
                        Exit For
                    End If
                Next
                For i As Integer = txtEndRackID.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtEndRackID.Text.Trim, i)) = True Then
                        EndPrefix = Strings.Left(txtEndRackID.Text.Trim, txtEndRackID.Text.Trim.Length - i)
                        EndRunDigit = i
                        Exit For
                    End If
                Next
                If iniPrefix <> EndPrefix Or iniPrefix = "" Or EndPrefix = "" Or iniRunDigit = 0 Or EndRunDigit = 0 Then
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtInitialRackID, OPE_Controls.MessageType.InvalidFormat)
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtEndRackID, OPE_Controls.MessageType.InvalidFormat)
                End If
            End If
        End If

        Return bTrue
    End Function

    Private Sub DataToGrid()
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        Dim drAdd As DataRow = Nothing
        If fNew = True Then
            drAdd = dt.NewRow
            drAdd("RackHeaderID") = 0
            drAdd("Qty") = 0
            drAdd("sta") = "N"
        Else
            grdData.Rows(mRow).Selected = True
            drAdd = grdData.SelectedRow
            If drAdd("sta") = "" Then drAdd("sta") = "U"
        End If
        drAdd("ModelID") = cboModel.SelectedValue
        drAdd("Model") = cboModel.SelectedRow("Model")
        drAdd("Code") = txtCode.Text.Trim
        drAdd("Type") = cboType.SelectedValue
        drAdd("TypeName") = cboType.SelectedRow("Name")
        drAdd("Remark") = txtRemark.Text.Trim
        drAdd("InitialNo") = txtInitialNo.Text.Trim
        drAdd("EndNo") = txtEndNo.Text.Trim
        drAdd("InitialRackID") = txtInitialRackID.Text.Trim
        drAdd("EndRackID") = txtEndRackID.Text.Trim

        If fNew = True Then
            dt.Rows.Add(drAdd)
            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew
        End If

        btnSave.Enabled = True
    End Sub
#End Region
    Private Function CheckUpdateData() As Boolean
        If grpUpdateData.Visible = True Then
            MessageBox.Show("Please click OK or Cancel to close editing area")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cboType_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboType.SelectedValueChanged
        If cboType.DataSource Is Nothing OrElse cboType.SelectedRow Is Nothing Then Exit Sub

        With cboModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            If CustomerCode = "MB" Then
                Select Case cboType.SelectedRow("ID")
                    Case SystemINI.ModelTypeMB.Front : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and FrontFlag=1")
                    Case SystemINI.ModelTypeMB.Rear : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and RearFlag=1")
                    Case SystemINI.ModelTypeMB.BPS : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and BPSFlag=1")
                End Select
            Else
                Select Case cboType.SelectedRow("ID")
                    Case SystemINI.ModelTypeBMW.Front : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and FrontFlag=1")
                    Case SystemINI.ModelTypeBMW.Rear : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and RearFlag=1")
                    Case SystemINI.ModelTypeBMW.FrontRear : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and FrontRearFlag=1")
                    Case SystemINI.ModelTypeBMW.STB : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and STBFlag=1")
                    Case SystemINI.ModelTypeBMW.MBike : .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0 and MBikeFlag=1")
                    Case SystemINI.ModelTypeBMW.PTC
                        .DataSource = DataBase.DataSelect("MstModel" _
                                                  , "DelFlag=0 and PTCFlag=1" _
                                                  , , _
                                                  , "ID " & _
                                                    ",case when Model=ModelContainer then Model else Model + ' (' + ModelContainer + ')' end as Model" & _
                                                    ",FrontFlag,RearFlag,FrontRearFlag,STBFlag,MBikeFlag" & _
                                                    ",ColorA,ColorR,ColorG,ColorB" & _
                                                    ",ModelContainer,ModelContainerSeq,PTCFlag" & _
                                                    ",DelFlag" & _
                                                    ",CreateUser,CreateDate,UpdateUser,UpdateDate" _
                                                  , , _
                                                  , "Model")
                End Select
            End If
            .Enabled = True
            .SelectedIndex = -1
        End With
    End Sub
End Class