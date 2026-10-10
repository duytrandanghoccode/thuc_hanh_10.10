using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_4
{
    // 1. LỚP FORM BẮT BUỘC PHẢI ĐỨNG ĐẦU TIÊN
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form vừa load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp các lựa chọn chế độ xem vào ComboBox
            cboViewMode.Items.Clear();
            cboViewMode.Items.AddRange(new string[] { "Details", "LargeIcon", "SmallIcon", "List", "Tile" });
            cboViewMode.SelectedItem = "Details";

            // Cấu hình cột cho ListView ở chế độ Details
            lsvEmployees.View = View.Details;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;

            lsvEmployees.Columns.Clear();
            lsvEmployees.Columns.Add("Mã NV", 80);
            lsvEmployees.Columns.Add("Họ Tên", 160);
            lsvEmployees.Columns.Add("Chức vụ", 120);
            lsvEmployees.Columns.Add("Ngày vào làm", 110);

            // Nạp cấu trúc cây dữ liệu mẫu
            TaoDuLieuCayMau();
        }

        // Hàm tạo cấu trúc cây phòng ban mẫu
        private void TaoDuLieuCayMau()
        {
            tvDepartments.Nodes.Clear();

            // Node gốc: CÔNG TY
            TreeNode rootNode = new TreeNode("CÔNG TY TNHH ABC");
            rootNode.Tag = new List<Employee>();

            // --- PHÒNG NHÂN SỰ ---
            TreeNode nodePhongNS = new TreeNode("Phòng Nhân sự");

            TreeNode nodeNhomTuyenDung = new TreeNode("Nhóm Tuyển dụng");
            nodeNhomTuyenDung.Tag = new List<Employee>()
            {
                new Employee("NV001", "Nguyễn Văn A", "Trưởng nhóm", new DateTime(2021, 03, 15)),
                new Employee("NV002", "Trần Thị B", "Chuyên viên tuyển dụng", new DateTime(2022, 06, 01))
            };

            TreeNode nodeNhomDaoTao = new TreeNode("Nhóm Đào tạo");
            nodeNhomDaoTao.Tag = new List<Employee>()
            {
                new Employee("NV003", "Lê Văn C", "Chuyên viên đào tạo", new DateTime(2023, 01, 10))
            };

            nodePhongNS.Nodes.Add(nodeNhomTuyenDung);
            nodePhongNS.Nodes.Add(nodeNhomDaoTao);

            // --- PHÒNG KỸ THUẬT ---
            TreeNode nodePhongKT = new TreeNode("Phòng Kỹ thuật");

            TreeNode nodeNhomDev = new TreeNode("Nhóm Dev C#");
            nodeNhomDev.Tag = new List<Employee>()
            {
                new Employee("NV004", "Phạm Hoàng D", "Lập trình viên Senior", new DateTime(2020, 08, 20)),
                new Employee("NV005", "Vũ Minh E", "Lập trình viên Junior", new DateTime(2024, 02, 12))
            };

            TreeNode nodeNhomTester = new TreeNode("Nhóm QA/Tester");
            nodeNhomTester.Tag = new List<Employee>()
            {
                new Employee("NV006", "Đặng Thị F", "Tester", new DateTime(2022, 11, 05))
            };

            nodePhongKT.Nodes.Add(nodeNhomDev);
            nodePhongKT.Nodes.Add(nodeNhomTester);

            // Thêm các phòng vào Node gốc
            rootNode.Nodes.Add(nodePhongNS);
            rootNode.Nodes.Add(nodePhongKT);

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
        }

        // Sự kiện click chọn Node trên TreeView
        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();

            TreeNode selectedNode = e.Node;
            List<Employee> dsHienThi = new List<Employee>();

            LayDanhSachNhanVienTuNode(selectedNode, dsHienThi);

            foreach (Employee emp in dsHienThi)
            {
                ListViewItem item = new ListViewItem(emp.MaNV);
                item.SubItems.Add(emp.HoTen);
                item.SubItems.Add(emp.ChucVu);
                item.SubItems.Add(emp.NgayVaoLam.ToString("dd/MM/yyyy"));
                item.ImageIndex = 0;

                lsvEmployees.Items.Add(item);
            }
        }

        // Hàm đệ quy lấy nhân viên thuộc Node hiện tại và các Node con
        private void LayDanhSachNhanVienTuNode(TreeNode node, List<Employee> resultList)
        {
            if (node.Tag is List<Employee> listEmp)
            {
                resultList.AddRange(listEmp);
            }

            foreach (TreeNode childNode in node.Nodes)
            {
                LayDanhSachNhanVienTuNode(childNode, resultList);
            }
        }

        // Chọn chế độ xem ListView từ ComboBox
        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem == null) return;

            string selectedMode = cboViewMode.SelectedItem.ToString();

            switch (selectedMode)
            {
                case "Details":
                    lsvEmployees.View = View.Details;
                    break;
                case "LargeIcon":
                    lsvEmployees.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case "List":
                    lsvEmployees.View = View.List;
                    break;
                case "Tile":
                    lsvEmployees.View = View.Tile;
                    break;
            }
        }
    }

    // 2. LỚP ĐỐI TƯỢNG PHỤ ĐẶT Ở PHÍA DƯỚI LỚP FORM
    public class Employee
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }

        public Employee(string maNV, string hoTen, string chucVu, DateTime ngayVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
        }
    }
}