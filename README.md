# PHẦN MỀM QUẢN LÝ CHĂM SÓC CÂY CẢNH TRƯỜNG HỌC

*CSCC* : CHĂM SÓC CÂY CẢNH.

 by: Phạm Quốc Khánh, Lê Phùng Khánh Minh, Nguyễn Viết Hải.

 **Ngôn ngữ: C#, MySQL**

 **Phần mềm:**
 - Visual Studio 2019: [VS2019](https://visualstudio.microsoft.com/vs/)
    - .NET Standard 2.0
    - .NET Framework 4.7.2
 - Bunifu: version 1.9.0.1 [Bunifu](https://bunifuframework.com/products/bunifu-ui-winforms/)
 - Telerik: version 2019.1.115 
 - Microsoft Report: version 15.3.1
 - MySQL: version 8.0.16
    - MySQL Server 8.0.16
    - MySQL for Visual Studio 1.2.8
    - Connector/NET 8.0.16

 ## GIỚI THIỆU

 Phần mềm quản lý CSCC dùng để quản lý các công việc liên quan đến vấn đề quản lý và chăm sóc cây cảnh trong trường học bảo gồm các công việc như sau:
 - Trồng thêm cây cảnh mới
 - Lập lịch chăm sóc
 - Tra cứu và quản lý cây cảnh
 - Lập phiếu mua vật tư
 - Lập báo cáo tháng

 Các công việc trên ràng buộc bằng một số các quy định(QĐ) để phù hợp với yêu cầu của phần mềm.
 - QĐ1: 
    - Có 2 loại cây cảnh (cần ánh sáng, bóng râm).
    - Có 3 vị trí trồng (ban công, cửa sổ, trước cổng). Mỗi vị trí tối đa 4 cây.
 - QĐ 2:
    - Có 2 vật tư (nước, phân đạm).
    - Đơn vị tính (lit, gam).
 - QĐ 4:
    - Số tiền mua vật tư không quá 100.000VND
 - QĐ 6:
    - QĐ 6.1: 
        - Thay đổi các vị trí có thể đặt cây cảnh.
        - Thay đổi số cây cảnh tối đa trong một vị trí.
    - QĐ 6.2:
        - Thay đổi một số vật tư.
        - Thay đổi số tiền tối đa dùng để mua vật tư.

 ## QUICK START

 - Báo cáo đồ án: [Report](https://github.com/KhanhPham0102/TakeCareOfPlants/blob/master/Bao_Cao_Do_An.docx)
 - Source Code: [project_code](https://github.com/KhanhPham0102/TakeCareOfPlants/tree/master/TakeCareOfPlants)
 - Database: [database](https://github.com/KhanhPham0102/TakeCareOfPlants/blob/master/NEWDB.sql)
