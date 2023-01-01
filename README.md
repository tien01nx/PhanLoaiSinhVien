# PhanLoaiSinhVien
TỔNG QUAN ĐỀ TÀI
1. Khảo sát hiện trạng
- Hiện nay, ngành công nghệ thông tin được xem là một ngành mũi nhọn của các quốc gia, đặc biệt là các quốc gia đang phát triển. Vì vậy,số lượng sinh viên học ngành này càng ngày càng cao, các trường cũng đầu tư và phát triển giáo dục để cho ra các kĩ sư có tài giúp cho ngành công nghệ nước nhà.  Sự bùng nổ thông tin và sự phát triển mạnh mẽ của công nghệ kỹ thuật số, yêu cầu muốn phát triển thì phải tin học hóa vào tất cả các ngành, các lĩnh vực.
Việc áp dụng các sản phẩm ứng dụng phần mềm để giảm làm việc bằng thủ công ngày càng được áp dụng nhiều trong nhiều lĩnh vực.
- Hiện nay, các trường đại học phải quản lý một khối lượng lớn các sinh viên. Do đó, công việc quản lý điểm sinh viên ngày càng phức tạp hơn. 
- Hơn nữa, công tác quản lý không chỉ đơn thuần là quản lý về điểm của các sinh viên … mà công việc quản lý còn phải đáp ứng nhu cầu về việc báo cáo về tình hình học tập của sinh viên … để từ đó có thể đưa ra các kết luận , báo cáo và định hướng cho sinh viên. Nhưng với việc lưu trữ và xử lý bằng thủ công như hiện nay thì sẽ tốn rất nhiều thời gian và nhân lực, xác suất sai lệch, khắc phục khi lỗi số liệu rất khó sửa chữa. Do đó cần phải tin học hóa hình thức quản lý, cụ thể là xây dựng một phần mềm để đáp ứng nhu cầu quản lý toàn diện, thống nhất và đạt hiệu quả cao nhất cho các khoa vad nhà trường.


2. Mô tả bài toán
- Sinh viên phải cung cấp các thông tin như: Họ tên, giới tính, ngày sinh, email, số điện thoại và phòng quản lý sinh viên sẽ nhập, lưu trữ các thông tin trên.
- Bộ phận quản lý sẽ đưa cho sinh viên thông tin về lớp hành chính ,lớp học phần và điểm của các môn học.
- Đối với Quản lý thì có thể quản lý thông tin của các sinh viên và giảng viên đang công tác và học tập tại từng khoa, quản lý,tra cứu thông tin các lớp hành chính và các lớp học phần.
- Đối với Giảng viên giảng dạy sẽ quản lý và nhập điểm cho sinh viên của lớp học phần mà mình đang dạy.
- Thống kê báo các điểm của lớp học phần, bảng điểm cá nhân của từng sinh viên, xếp loại học lực,tính trung bình chung tích lũy

3. Yêu cầu chức năng
Chương trình quản lý điểm của sinh viên cần có các chức năng chính sau:
-	Đối với Quản lý
+ Có thể xem, thêm, cập nhật các các Môn học,Lớp hành chính, Lớp học phần, Sinh viên, Giảng viên và Tài khoản đăng nhập hệ thống.
+ Báo cáo thống kê.
-	Đối với Giảng viên
+ Có thể xem, thêm, cập nhật thông tin sinh viên, nhập điểm sinh viên theo lớp giảng dạy.
+ Báo cáo thống kê
-	Đối với Sinh viên
+ Xem thông tin cá nhân, Kết quả học tập cá nhân, bảng điểm cá nhân.
+ In Kết quả học tập , Bảng điểm cá nhân.
-	Các chức năng khác 
+ Đổi mật khẩu
 
II. THIẾT KẾ CSDL MỨC LOGIC
1.	Thiết kế cơ sở dữ liệu mức khái niệm – mô hình ER
1.1.	Xác định thực thể - thuộc tính và phân loại thuộc tính
(1)	SinhVien (MaSV, TenSV, GioiTinhSV, NgaySinhSV, EmailSV,SdtSV)
	+ MaSV là thuộc tính khoá.
(2)	GiangVien (MaGV, TenGV, GioiTinhGV, EmailGV, SdtGV)
	+ MaGV là thuộc tính khoá.
(3)	Mon (MaM, TenMon, Sotin)
	+ MaM là thuộc tính khóa
(4)	LopHanhChinh (MaLHC, TenLHC, Ngaylap)
	+ MaLHC là thuộc tính khoá.
(5)	LopHocPhan (MaLHP,NgayBD, NgayKT) 
+ MaLHP là thuộc tính khóa	
1.2.	Xác định liên kết và các kiểu liên kết
- Giữa thực thể LopHanhChinh và thực thể SinhVien có kiểu liên kết là 1 - N, vì:
	+ Một LopHanhChinh có nhiều SinhVien.
	+ Nhưng một SinhVien chỉ thuộc một LopHanhChinh.
	
 ![image](https://user-images.githubusercontent.com/114860203/210174030-384a6706-3879-4e3a-a688-fd09f5eccd2a.png)

- Giữa thực thể MonHoc và thực thể LopHocPhan có kiểu liên kết là 1-N, vì:
	+ Một MonHoc có thể thuộc nhiều LopHocPhan.
	+ Nhưng một LopHocPhan chỉ giảng dạy một MonHoc.
	
![image](https://user-images.githubusercontent.com/114860203/210174040-e40d438b-4ce6-4639-8006-778fb5a202be.png)


 
−	Giữa thực thể GiangVien và thực thể LopHocPhan có kiểu liên kết là 1 - N, vì:
	+ Một GiangVien có thể giảng dạy ở nhiều LopHocPhan
	+ Nhưng một LopHocPhan chỉ có một GiangVien dạy
  
  ![image](https://user-images.githubusercontent.com/114860203/210174043-f48a2b08-ce8a-4c66-ba49-5c17d9667de9.png)

 
−	Giữa thực thể SinhVien và thực thể LopHocPhan có kiểu liên kết là M – N, vì:
	+ Một SinhVien có thể học ở nhiều LopHocPhan
	+ Và một LopHocPhan có thể có nhiều SinhVien học
  
  ![image](https://user-images.githubusercontent.com/114860203/210174050-9fde3323-cd35-42f8-abb1-c024adb2c1d3.png)


 
−	Giữa thực thể GiangVien và thực thể LopHocPhan có kiểu liên kết là M - N, vì:
	+ Một GiangVien có thể giảng dạy ở nhiều Mon
	+ Và một Mon có thể có nhiều GiangVien dạy
  
  ![image](https://user-images.githubusercontent.com/114860203/210174059-70484015-1b74-435d-b6bf-ab2f43da6d2b.png)


1.3.	Mô hình ER

![image](https://user-images.githubusercontent.com/114860203/210174067-464be2a6-fa5c-4d0a-aac7-743642252f40.png)

 
2.	Thiết kế cơ sở dữ liệu mức logic – mô hình quan hệ
2.1.	Chuẩn hóa quan hệ
	Áp dụng quy tắc 1: Chuyển kiểu thực thể mạnh
-	(1) SinhVien (MaSV, TenSV, GioiTinhSV, NgaySinhSV, EmailSV,SdtSV) 
-	(2) GiangVien (MaGV, TenGV, GioiTinhGV, EmailGV, SdtGV)
-	(3) MonHoc (MaM, TenMon, Sotin)
-	(4) LopHanhChinh (MaLHC, TenLHC, Ngaylap)
-	(5) LopHocPhan (MaLHP,NgayBD, NgayKT

	Áp dụng quy tắc: Chuyển các liên kết 1-N
-	(1’) SinhVien (MaSV, TenSV, GioiTinhSV, NgaySinhSV, EmailSV,SdtSV,MaLHC)
-	(5’) LopHocPhan (MaLHP, MaMon,NgayBD, NgayKT)
-	(5’’) LopHocPhan (MaLHP, MaMon, MaGV, NgayBD, NgayKT)
	Áp dụng quy tắc 6: Chuyển các liên kết M-N
-	(6) Diem (MaSV, MaLHP,DiemThi)
-	(7) MonGiangVien(MaM, MaGV)

2.2.	Cơ sở dữ liệu cuối cùng
⇨ Kết quả của việc chuyển đổi:
-	(1’) SinhVien (MaSV, TenSV, GioiTinh, NgaySinh, Email,CCCD,MaLop)
-	(2) GiangVien (MaGV, TenGV, SDT, Email, CCCD)
-	(3) MonHoc (MaMon, TenMon, SotinChi)
-	(4) LopHanhChinh (MaLop, TenLop)
-	(5’’) LopHocPhan (MaLHP, MaMon, MaGV,ThoiGianBatDau, ThoiGianKetThuc)
- (6) Diem (MaSV, MaLHP, DiemThi)
-	(7) MonGiangVien(MaM, MaGV)

 
III. TẠO KẾT NỐI GIỮA CÁC BẢNG

![image](https://user-images.githubusercontent.com/114860203/210174080-ff4875d4-4995-4274-8259-baa27c0602d9.png)


 
IV. XÂY DỰNG CHƯƠNG TRÌNH
1.	Giao diện trang chủ

![image](https://user-images.githubusercontent.com/114860203/210174092-b76f506d-2c38-47a3-b30e-beb3213ec94b.png)

 
1.1.	Giao diện form Đăng nhập

![image](https://user-images.githubusercontent.com/114860203/210174096-dc085572-3541-49aa-959d-1ce0b73be55d.png)


 
1.2.	Giao diện form quản lý Sinh Viên

![image](https://user-images.githubusercontent.com/114860203/210174106-07323fb2-544c-4cfa-9d75-0fa77004ce25.png)


1.3.	Giao diện form quản lý Giảng Viên

![image](https://user-images.githubusercontent.com/114860203/210174112-6d3a561a-24eb-4898-bd5f-343b05800ebb.png)

 
1.4.	Giao diện form quản lý Lớp Hành Chính

![image](https://user-images.githubusercontent.com/114860203/210174118-fcd2c81f-b66a-4632-8082-e762005bb1cb.png)


1.5.	Giao diện form quản lý Môn Học
 
 
 ![image](https://user-images.githubusercontent.com/114860203/210174125-e67e6e4b-2975-4047-8413-02bae32f9e37.png)


1.6.	Giao diện form quản lý Lớp Học Phần

![image](https://user-images.githubusercontent.com/114860203/210174127-a517896d-0959-427d-8bf1-b735403384f0.png)


1.7.	Giao diện form quản lý Điểm

![image](https://user-images.githubusercontent.com/114860203/210174129-6cb19370-5291-493f-be00-9d3b58a67351.png)


 
1.8.	Giao Diện form quản lý Tài khoản đăng nhập

![image](https://user-images.githubusercontent.com/114860203/210174135-6c9c46ed-4918-4138-8121-c9e23365d89f.png)


1.9.	Giao diện form Cá nhân của Sinh Viên

![image](https://user-images.githubusercontent.com/114860203/210174145-1aac7cb5-106e-492a-8c91-f1931704422c.png)

 
1.10.	Giao diện form Cá nhân của Giảng Viên

![image](https://user-images.githubusercontent.com/114860203/210174155-c8c096b9-0625-477d-b23a-ec85b840b6b8.png)


![image](https://user-images.githubusercontent.com/114860203/210174161-6ad88a6e-2463-4a31-ae53-6ae1c0d8fa3a.png)




