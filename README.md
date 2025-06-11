# Hệ thống Quản lý Bán hàng - Công ty Phân phối Quý Thiện

## 📘 Giới thiệu

Đây là dự án môn học **Quản trị Cơ sở Dữ liệu**, nhằm xây dựng một hệ thống quản lý bán hàng cho một công ty phân phối. Dự án được thực hiện bởi Nhóm 2 - lớp 48K21.2, với mục tiêu mô phỏng đầy đủ quy trình từ quản lý khách hàng, nhà cung cấp, đơn hàng, xuất/nhập kho, thanh toán đến thống kê báo cáo.

## 👥 Thành viên nhóm

- Trần Chế Mỹ Duyên  
- Nguyễn Thị Thùy Linh  
- Dương Công Tùng  
- Nguyễn Thị Thúy  
- Dương Ngọc Phú

**GVHD**: Cao Thị Nhâm  
**Thời gian thực hiện**: 11/2021

---

## 🗃️ Nội dung chính

### 1. Thiết kế Cơ sở Dữ liệu

- Thiết kế ở mức **khái niệm**: ERD cho phiếu nhập kho, xuất kho, đơn hàng, phiếu thanh toán
- Thiết kế ở mức **logic**: xác định các bảng và quan hệ
- Thiết kế ở mức **vật lý**: định nghĩa các bảng SQL, kiểu dữ liệu, khóa chính/phụ
- Chuẩn hóa dữ liệu: tách quan hệ 1-N thành bảng riêng biệt

### 2. Xây dựng Cơ sở Dữ liệu

- Tạo CSDL `CTPhanPhoi`
- Viết script tạo bảng, khóa chính - khóa ngoại
- Tạo **14 thủ tục** sinh dữ liệu ngẫu nhiên vào các bảng (mỗi bảng 1000+ bản ghi)

### 3. Các Module hỗ trợ

> Tạo qua hàm, stored procedure, trigger

#### 🔢 Tính toán - Kiểm tra:
- Tổng tiền đơn hàng, doanh thu, chi phí, lợi nhuận theo **tháng/quý/năm**
- Tồn kho thực tế tại thời điểm kiểm tra

#### 🔍 Kiểm tra dữ liệu:
- Trigger kiểm tra tính hợp lệ khi thêm khách hàng, nhân viên, nhà cung cấp, hàng hóa

#### 📊 Báo cáo & thống kê:
- Top 5 khách hàng đặt nhiều đơn nhất trong năm
- Top 10 sản phẩm bán chạy nhất (>50.000đ) trong tháng
- Top 3 nhân viên bán nhiều đơn nhất trong năm
- Tháng có doanh thu cao/thấp nhất trong năm

---

## 🛠️ Kỹ thuật sử dụng

- **Ngôn ngữ**: T-SQL
- **Môi trường**: SQL Server Management Studio (SSMS)
- **Chức năng chính**:
  - `CREATE DATABASE`, `CREATE TABLE`, `ALTER PROCEDURE`, `TRIGGER`, `FUNCTION`
  - `INSERT`, `JOIN`, `GROUP BY`, `ROLLBACK`, `OUTPUT`, `ISNULL()`, `CAST()`

---

## 🚀 Cách chạy dự án

1. Mở SSMS, tạo CSDL `CTPhanPhoi`
2. Chạy script tạo bảng
3. Chạy lần lượt các thủ tục tạo dữ liệu
4. Thêm triggers và modules xử lý 
5. Truy vấn thử nghiệm với

---

## 📌 Ghi chú

- Tất cả mã được viết thủ công và tuân theo chuẩn SQL Server
- Mỗi module đã được kiểm tra với dữ liệu thực tế lên tới 1000 bản ghi
- Có thể dễ dàng mở rộng cho mục đích thống kê thực tế hoặc tích hợp với ứng dụng front-end

---

## 📄 Giấy phép

Dự án được thực hiện trong phạm vi học tập, **không sử dụng cho mục đích thương mại**.

---

## ❤️ Cảm ơn

Cảm ơn cô **Cao Thị Nhâm** đã hướng dẫn nhóm thực hiện đề tài.
