#nullable enable

namespace QL_NhaTro;

public sealed partial class FormKhachThue
{
    private System.ComponentModel.IContainer? components;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        rootLayout = new TableLayoutPanel();
        leftPanel = new Panel();
        entryGroup = new GroupBox();
        fieldsTable = new TableLayoutPanel();
        nameField = new TableLayoutPanel();
        nameCaption = new Label();
        genderGroup = new GroupBox();
        genderFlow = new FlowLayoutPanel();
        birthField = new TableLayoutPanel();
        birthCaption = new Label();
        phoneField = new TableLayoutPanel();
        phoneCaption = new Label();
        roomField = new TableLayoutPanel();
        roomCaption = new Label();
        provinceField = new TableLayoutPanel();
        provinceCaption = new Label();
        wardField = new TableLayoutPanel();
        wardCaption = new Label();
        buttonFlow = new FlowLayoutPanel();
        rightPanel = new TableLayoutPanel();
        searchFlow = new FlowLayoutPanel();
        roomFilterCaption = new Label();
        provinceFilterCaption = new Label();
        statusPanel = new Panel();
        _nameBox = new TextBox();
        _maleRadio = new RadioButton();
        _femaleRadio = new RadioButton();
        _birthPicker = new DateTimePicker();
        _phoneBox = new TextBox();
        _roomCombo = new ComboBox();
        _provinceCombo = new ComboBox();
        _wardCombo = new ComboBox();
        _registeredCheck = new CheckBox();
        _searchBox = new TextBox();
        _roomFilter = new ComboBox();
        _provinceFilter = new ComboBox();
        _grid = new DataGridView();
        columnMaKhach = new DataGridViewTextBoxColumn();
        columnHoTen = new DataGridViewTextBoxColumn();
        columnSoDienThoai = new DataGridViewTextBoxColumn();
        columnTenPhong = new DataGridViewTextBoxColumn();
        columnGiaThue = new DataGridViewTextBoxColumn();
        columnQueQuan = new DataGridViewTextBoxColumn();
        columnTamTru = new DataGridViewCheckBoxColumn();
        _statusLabel = new Label();
        _addButton = new Button();
        _editButton = new Button();
        _deleteButton = new Button();
        _clearButton = new Button();
        _findButton = new Button();
        _clearFilterButton = new Button();
        _testErrorButton = new Button();

        rootLayout.SuspendLayout();
        leftPanel.SuspendLayout();
        entryGroup.SuspendLayout();
        fieldsTable.SuspendLayout();
        nameField.SuspendLayout();
        genderGroup.SuspendLayout();
        genderFlow.SuspendLayout();
        birthField.SuspendLayout();
        phoneField.SuspendLayout();
        roomField.SuspendLayout();
        provinceField.SuspendLayout();
        wardField.SuspendLayout();
        buttonFlow.SuspendLayout();
        rightPanel.SuspendLayout();
        searchFlow.SuspendLayout();
        statusPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();

        // Main layout
        rootLayout.BackColor = Color.FromArgb(246, 248, 251);
        rootLayout.ColumnCount = 2;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 365F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Padding = new Padding(12);
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        rootLayout.Controls.Add(leftPanel, 0, 0);
        rootLayout.Controls.Add(rightPanel, 1, 0);
        rootLayout.Controls.Add(statusPanel, 0, 1);
        rootLayout.SetColumnSpan(statusPanel, 2);

        // Tenant information panel
        leftPanel.Dock = DockStyle.Fill;
        leftPanel.Padding = new Padding(0, 0, 10, 0);
        leftPanel.Controls.Add(entryGroup);

        entryGroup.BackColor = Color.White;
        entryGroup.Dock = DockStyle.Fill;
        entryGroup.Padding = new Padding(12);
        entryGroup.Text = "Thông tin khách thuê";
        entryGroup.Controls.Add(fieldsTable);

        fieldsTable.ColumnCount = 1;
        fieldsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        fieldsTable.Dock = DockStyle.Fill;
        fieldsTable.Padding = new Padding(6, 8, 6, 4);
        fieldsTable.RowCount = 9;
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
        fieldsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        fieldsTable.Controls.Add(nameField, 0, 0);
        fieldsTable.Controls.Add(genderGroup, 0, 1);
        fieldsTable.Controls.Add(birthField, 0, 2);
        fieldsTable.Controls.Add(phoneField, 0, 3);
        fieldsTable.Controls.Add(roomField, 0, 4);
        fieldsTable.Controls.Add(provinceField, 0, 5);
        fieldsTable.Controls.Add(wardField, 0, 6);
        fieldsTable.Controls.Add(_registeredCheck, 0, 7);
        fieldsTable.Controls.Add(buttonFlow, 0, 8);

        nameField.ColumnCount = 2;
        nameField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        nameField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        nameField.Dock = DockStyle.Fill;
        nameField.Padding = new Padding(0, 3, 0, 3);
        nameField.RowCount = 1;
        nameField.Controls.Add(nameCaption, 0, 0);
        nameField.Controls.Add(_nameBox, 1, 0);
        nameCaption.Dock = DockStyle.Fill;
        nameCaption.Text = "Họ tên";
        nameCaption.TextAlign = ContentAlignment.MiddleLeft;
        _nameBox.Dock = DockStyle.Fill;
        _nameBox.Font = new Font("Segoe UI", 9F);
        _nameBox.Margin = new Padding(0, 4, 0, 4);
        _nameBox.MaxLength = 100;

        genderGroup.Dock = DockStyle.Fill;
        genderGroup.Padding = new Padding(10, 4, 4, 4);
        genderGroup.Text = "Giới tính";
        genderGroup.Controls.Add(genderFlow);
        genderFlow.Dock = DockStyle.Fill;
        genderFlow.FlowDirection = FlowDirection.LeftToRight;
        genderFlow.WrapContents = false;
        genderFlow.Controls.Add(_maleRadio);
        genderFlow.Controls.Add(_femaleRadio);
        _maleRadio.AutoSize = true;
        _maleRadio.Checked = true;
        _maleRadio.Text = "Nam";
        _femaleRadio.AutoSize = true;
        _femaleRadio.Text = "Nữ";

        birthField.ColumnCount = 2;
        birthField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        birthField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        birthField.Dock = DockStyle.Fill;
        birthField.Padding = new Padding(0, 3, 0, 3);
        birthField.RowCount = 1;
        birthField.Controls.Add(birthCaption, 0, 0);
        birthField.Controls.Add(_birthPicker, 1, 0);
        birthCaption.Dock = DockStyle.Fill;
        birthCaption.Text = "Ngày sinh";
        birthCaption.TextAlign = ContentAlignment.MiddleLeft;
        _birthPicker.Dock = DockStyle.Fill;
        _birthPicker.Format = DateTimePickerFormat.Short;
        _birthPicker.Margin = new Padding(0, 4, 0, 4);

        phoneField.ColumnCount = 2;
        phoneField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        phoneField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        phoneField.Dock = DockStyle.Fill;
        phoneField.Padding = new Padding(0, 3, 0, 3);
        phoneField.RowCount = 1;
        phoneField.Controls.Add(phoneCaption, 0, 0);
        phoneField.Controls.Add(_phoneBox, 1, 0);
        phoneCaption.Dock = DockStyle.Fill;
        phoneCaption.Text = "Số điện thoại";
        phoneCaption.TextAlign = ContentAlignment.MiddleLeft;
        _phoneBox.Dock = DockStyle.Fill;
        _phoneBox.Font = new Font("Segoe UI", 9F);
        _phoneBox.Margin = new Padding(0, 4, 0, 4);
        _phoneBox.MaxLength = 15;

        roomField.ColumnCount = 2;
        roomField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        roomField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        roomField.Dock = DockStyle.Fill;
        roomField.Padding = new Padding(0, 3, 0, 3);
        roomField.RowCount = 1;
        roomField.Controls.Add(roomCaption, 0, 0);
        roomField.Controls.Add(_roomCombo, 1, 0);
        roomCaption.Dock = DockStyle.Fill;
        roomCaption.Text = "Phòng";
        roomCaption.TextAlign = ContentAlignment.MiddleLeft;
        _roomCombo.Dock = DockStyle.Fill;
        _roomCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _roomCombo.Font = new Font("Segoe UI", 9F);
        _roomCombo.Margin = new Padding(0, 4, 0, 4);

        provinceField.ColumnCount = 2;
        provinceField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        provinceField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        provinceField.Dock = DockStyle.Fill;
        provinceField.Padding = new Padding(0, 3, 0, 3);
        provinceField.RowCount = 1;
        provinceField.Controls.Add(provinceCaption, 0, 0);
        provinceField.Controls.Add(_provinceCombo, 1, 0);
        provinceCaption.Dock = DockStyle.Fill;
        provinceCaption.Text = "Tỉnh/Thành";
        provinceCaption.TextAlign = ContentAlignment.MiddleLeft;
        _provinceCombo.Dock = DockStyle.Fill;
        _provinceCombo.DropDownStyle = ComboBoxStyle.DropDown;
        _provinceCombo.Font = new Font("Segoe UI", 9F);
        _provinceCombo.Margin = new Padding(0, 4, 0, 4);

        wardField.ColumnCount = 2;
        wardField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        wardField.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        wardField.Dock = DockStyle.Fill;
        wardField.Padding = new Padding(0, 3, 0, 3);
        wardField.RowCount = 1;
        wardField.Controls.Add(wardCaption, 0, 0);
        wardField.Controls.Add(_wardCombo, 1, 0);
        wardCaption.Dock = DockStyle.Fill;
        wardCaption.Text = "Phường/Xã";
        wardCaption.TextAlign = ContentAlignment.MiddleLeft;
        _wardCombo.Dock = DockStyle.Fill;
        _wardCombo.DropDownStyle = ComboBoxStyle.DropDown;
        _wardCombo.Font = new Font("Segoe UI", 9F);
        _wardCombo.Margin = new Padding(0, 4, 0, 4);

        _registeredCheck.AutoSize = true;
        _registeredCheck.Text = "Đã đăng ký tạm trú";

        buttonFlow.Dock = DockStyle.Fill;
        buttonFlow.FlowDirection = FlowDirection.LeftToRight;
        buttonFlow.Padding = new Padding(0, 3, 0, 0);
        buttonFlow.WrapContents = false;
        buttonFlow.Controls.Add(_addButton);
        buttonFlow.Controls.Add(_editButton);
        buttonFlow.Controls.Add(_deleteButton);
        buttonFlow.Controls.Add(_clearButton);
        _addButton.Size = new Size(70, 34);
        _addButton.Text = "Thêm";
        _editButton.Size = new Size(70, 34);
        _editButton.Text = "Sửa";
        _deleteButton.Size = new Size(70, 34);
        _deleteButton.Text = "Xóa";
        _clearButton.Size = new Size(88, 34);
        _clearButton.Text = "Làm mới";

        // Search and tenant list
        rightPanel.ColumnCount = 1;
        rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rightPanel.Dock = DockStyle.Fill;
        rightPanel.RowCount = 2;
        rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rightPanel.Controls.Add(searchFlow, 0, 0);
        rightPanel.Controls.Add(_grid, 0, 1);

        searchFlow.BackColor = Color.FromArgb(246, 248, 251);
        searchFlow.Dock = DockStyle.Fill;
        searchFlow.FlowDirection = FlowDirection.LeftToRight;
        searchFlow.Padding = new Padding(0, 4, 0, 2);
        searchFlow.WrapContents = false;
        searchFlow.Controls.Add(_searchBox);
        searchFlow.Controls.Add(roomFilterCaption);
        searchFlow.Controls.Add(_roomFilter);
        searchFlow.Controls.Add(provinceFilterCaption);
        searchFlow.Controls.Add(_provinceFilter);
        searchFlow.Controls.Add(_findButton);
        searchFlow.Controls.Add(_clearFilterButton);
        _searchBox.PlaceholderText = "Tìm theo họ tên hoặc SĐT";
        _searchBox.Width = 270;
        roomFilterCaption.AutoSize = true;
        roomFilterCaption.Padding = new Padding(0, 8, 0, 0);
        roomFilterCaption.Text = "Phòng:";
        _roomFilter.Width = 150;
        _provinceFilter.Width = 165;
        provinceFilterCaption.AutoSize = true;
        provinceFilterCaption.Padding = new Padding(0, 8, 0, 0);
        provinceFilterCaption.Text = "Tỉnh:";
        _findButton.Width = 70;
        _findButton.Text = "Tìm";
        _clearFilterButton.Width = 78;
        _clearFilterButton.Text = "Bỏ lọc";

        _grid.AllowUserToAddRows = false;
        _grid.AllowUserToDeleteRows = false;
        _grid.AutoGenerateColumns = false;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.BackgroundColor = Color.White;
        _grid.BorderStyle = BorderStyle.FixedSingle;
        _grid.Dock = DockStyle.Fill;
        _grid.EnableHeadersVisualStyles = false;
        _grid.MultiSelect = false;
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 28;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(233, 239, 247);
        _grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        columnMaKhach.DataPropertyName = "MaKhach";
        columnMaKhach.Name = "MaKhach";
        columnMaKhach.Visible = false;
        columnHoTen.DataPropertyName = "HoTen";
        columnHoTen.FillWeight = 125F;
        columnHoTen.HeaderText = "Họ tên";
        columnHoTen.Name = "HoTen";
        columnSoDienThoai.DataPropertyName = "SoDienThoai";
        columnSoDienThoai.FillWeight = 100F;
        columnSoDienThoai.HeaderText = "SĐT";
        columnSoDienThoai.Name = "SoDienThoai";
        columnTenPhong.DataPropertyName = "TenPhong";
        columnTenPhong.FillWeight = 65F;
        columnTenPhong.HeaderText = "Phòng";
        columnTenPhong.Name = "TenPhong";
        columnGiaThue.DataPropertyName = "GiaThueDisplay";
        columnGiaThue.FillWeight = 85F;
        columnGiaThue.HeaderText = "Giá thuê";
        columnGiaThue.Name = "GiaThueDisplay";
        columnQueQuan.DataPropertyName = "QueQuan";
        columnQueQuan.FillWeight = 125F;
        columnQueQuan.HeaderText = "Quê quán";
        columnQueQuan.Name = "QueQuan";
        columnTamTru.DataPropertyName = "DaDangKyTamTru";
        columnTamTru.FillWeight = 55F;
        columnTamTru.HeaderText = "Tạm trú";
        columnTamTru.Name = "DaDangKyTamTru";
        _grid.Columns.AddRange(new DataGridViewColumn[]
        {
            columnMaKhach,
            columnHoTen,
            columnSoDienThoai,
            columnTenPhong,
            columnGiaThue,
            columnQueQuan,
            columnTamTru
        });

        statusPanel.Dock = DockStyle.Fill;
        statusPanel.Padding = new Padding(0, 5, 0, 0);
        statusPanel.Controls.Add(_statusLabel);
        _statusLabel.AutoSize = true;
        _statusLabel.Text = "Sẵn sàng";

        _testErrorButton.Text = "Gây lỗi thử";
        _testErrorButton.Tag = "Ctrl+Shift+E";
        _testErrorButton.Visible = false;
        Controls.Add(rootLayout);
        Controls.Add(_testErrorButton);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 251);
        ClientSize = new Size(1234, 751);
        Font = new Font("Segoe UI", 9F);
        KeyPreview = true;
        MinimumSize = new Size(1050, 690);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý nhà trọ - Khách thuê";

        statusPanel.ResumeLayout(false);
        statusPanel.PerformLayout();
        searchFlow.ResumeLayout(false);
        searchFlow.PerformLayout();
        rightPanel.ResumeLayout(false);
        buttonFlow.ResumeLayout(false);
        wardField.ResumeLayout(false);
        provinceField.ResumeLayout(false);
        roomField.ResumeLayout(false);
        phoneField.ResumeLayout(false);
        birthField.ResumeLayout(false);
        genderFlow.ResumeLayout(false);
        genderFlow.PerformLayout();
        genderGroup.ResumeLayout(false);
        nameField.ResumeLayout(false);
        fieldsTable.ResumeLayout(false);
        entryGroup.ResumeLayout(false);
        leftPanel.ResumeLayout(false);
        rootLayout.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
    }

    private TableLayoutPanel rootLayout = null!;
    private Panel leftPanel = null!;
    private GroupBox entryGroup = null!;
    private TableLayoutPanel fieldsTable = null!;
    private TableLayoutPanel nameField = null!;
    private Label nameCaption = null!;
    private GroupBox genderGroup = null!;
    private FlowLayoutPanel genderFlow = null!;
    private TableLayoutPanel birthField = null!;
    private Label birthCaption = null!;
    private TableLayoutPanel phoneField = null!;
    private Label phoneCaption = null!;
    private TableLayoutPanel roomField = null!;
    private Label roomCaption = null!;
    private TableLayoutPanel provinceField = null!;
    private Label provinceCaption = null!;
    private TableLayoutPanel wardField = null!;
    private Label wardCaption = null!;
    private FlowLayoutPanel buttonFlow = null!;
    private TableLayoutPanel rightPanel = null!;
    private FlowLayoutPanel searchFlow = null!;
    private Label roomFilterCaption = null!;
    private Label provinceFilterCaption = null!;
    private Panel statusPanel = null!;
    private TextBox _nameBox = null!;
    private RadioButton _maleRadio = null!;
    private RadioButton _femaleRadio = null!;
    private DateTimePicker _birthPicker = null!;
    private TextBox _phoneBox = null!;
    private ComboBox _roomCombo = null!;
    private ComboBox _provinceCombo = null!;
    private ComboBox _wardCombo = null!;
    private CheckBox _registeredCheck = null!;
    private TextBox _searchBox = null!;
    private ComboBox _roomFilter = null!;
    private ComboBox _provinceFilter = null!;
    private DataGridView _grid = null!;
    private DataGridViewTextBoxColumn columnMaKhach = null!;
    private DataGridViewTextBoxColumn columnHoTen = null!;
    private DataGridViewTextBoxColumn columnSoDienThoai = null!;
    private DataGridViewTextBoxColumn columnTenPhong = null!;
    private DataGridViewTextBoxColumn columnGiaThue = null!;
    private DataGridViewTextBoxColumn columnQueQuan = null!;
    private DataGridViewCheckBoxColumn columnTamTru = null!;
    private Label _statusLabel = null!;
    private Button _addButton = null!;
    private Button _editButton = null!;
    private Button _deleteButton = null!;
    private Button _clearButton = null!;
    private Button _findButton = null!;
    private Button _clearFilterButton = null!;
    private Button _testErrorButton = null!;
}
