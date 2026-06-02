# Quan ly ban dien thoai

Ung dung WinForms C# quan ly ban dien thoai theo mo hinh 3 layers:

- `DTO`: lop chua du lieu
- `DAL`: truy xuat SQL Server
- `BUS`: xu ly nghiep vu
- `GUI`: giao dien WinForms

## Cong nghe

- C# WinForms
- .NET 8
- SQL Server Express
- Microsoft.Data.SqlClient

## Co so du lieu

Chay file `database.sql` tren SQL Server de tao database:

```sql
QLBanDienThoai
```

Chuoi ket noi hien tai nam trong `bandienthoai/DAL/DBConnect.cs`:

```text
Data Source=.\SQLEXPRESS;Initial Catalog=QLBanDienThoai;Integrated Security=True;TrustServerCertificate=True
```

Tai khoan dang nhap duoc luu trong bang `TaiKhoan`. Hay them tai khoan vao SQL Server truoc khi dang nhap chuong trinh.

## Chuc nang chinh

- Dang nhap
- Quan ly hang dien thoai
- Quan ly dien thoai
- Them anh dien thoai
- Quan ly tinh trang moi/cu va phan tram chat luong
- Ban hang va lap hoa don
- Tu dong tru ton kho
- Xem danh sach hoa don
