\# QLHocVu-THL - Tác giả_Vũ Trường Thành




Ứng dụng \*\*Quản lý học vụ\*\* được phát triển bằng \*\*WinForms (.NET Framework)\*\* theo mô hình \*\*3 lớp (DAL – BUS – DTO)\*\*.



---



\## 🧱 Cấu trúc dự án

| Thư mục | Mô tả |

|----------|-------|

| \*\*DAL\*\* | Data Access Layer – chứa các lớp truy cập CSDL |

| \*\*BUS\*\* | Business Logic Layer – xử lý nghiệp vụ |

| \*\*DTO\*\* | Data Transfer Object – các lớp đối tượng dữ liệu |

| \*\*GUI\*\* | Giao diện người dùng (WinForms) |

| \*\*Database\*\* | Chứa script SQL (`QLHOCVU.sql`) và các stored procedure |



---



\## ⚙️ Hướng dẫn cài đặt

1\. \*\*Khôi phục cơ sở dữ liệu\*\*:

&nbsp;  - Mở SQL Server Management Studio (SSMS)

&nbsp;  - Chạy script:  

&nbsp;    ```sql

&nbsp;    Database/QLHOCVU.sql

&nbsp;    ```

Mở project trong Visual Studio:

Mở file QLHocVu-THL.sln

Kiểm tra file App.config → cập nhật chuỗi kết nối (connectionString) phù hợp với máy bạn.


