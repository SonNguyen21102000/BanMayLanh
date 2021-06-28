CREATE DATABASE QLBANHANG
USE QLBANHANG
CREATE TABLE DANGNHAP
(
	TENDN NVARCHAR(30),
	MK NVARCHAR(30),
)
CREATE TABLE CHATLIEU
(
	MACHATLIEU CHAR(10) NOT NULL,
	TENCHATLIEU NVARCHAR(30),
	PRIMARY KEY(MACHATLIEU)
)
CREATE TABLE HANG	
(
	MAHANG CHAR(10) NOT NULL,
	TENHANG NVARCHAR(30),
	MACHATLIEU CHAR(10),
	SOLUONG INT,
	DONGIANHAP FLOAT,
	DONGIABAN FLOAT,
	ANH NVARCHAR(200),
	GHICHU NVARCHAR(200),
	PRIMARY KEY(MAHANG),
	FOREIGN KEY(MACHATLIEU) REFERENCES CHATLIEU(MACHATLIEU)	
)
alter table HANG
alter column TENHANG NVARCHAR(100)
set dateformat dmy
CREATE TABLE NHANVIEN
(
	MANV CHAR(10) NOT NULL,
	TENNV NVARCHAR(30),
	GIOITINH NVARCHAR(10),
	DIACHI NVARCHAR(50),
	DT NVARCHAR(15),
	NGAYSINH NVARCHAR(15), 
	PRIMARY KEY(MANV),
)

CREATE TABLE KHACH
(
	MAKH CHAR(10) NOT NULL,
	TENKH NVARCHAR(30),
	DIACHI NVARCHAR(50),
	DT NVARCHAR(15),
	PRIMARY KEY(MAKH),
)
CREATE TABLE HDBANHANG
(
	MAHD CHAR(10) NOT NULL,
	MANV CHAR(10),
	NGAYBAN NVARCHAR(15),
	MAKH CHAR(10),
	TONGTIEN FLOAT,
	PRIMARY KEY(MAHD),
	FOREIGN KEY(MAKH) REFERENCES KHACH(MAKH),
	FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
CREATE TABLE CHITIETHDBANHANG
(
	MAHD CHAR(10) NOT NULL,
	MAHANG CHAR(10) NOT NULL,
	SOLUONG INT,
	DONGIA FLOAT,
	GIAMGIA FLOAT,
	THANHTIEN FLOAT,
	PRIMARY KEY(MAHD,MAHANG),
	FOREIGN KEY(MAHD) REFERENCES HDBANHANG(MAHD),
	FOREIGN KEY(MAHANG) REFERENCES HANG(MAHANG),
)
alter table CHITIETHDBANHANG
alter column THANHTIEN MONEY
CREATE TABLE BIENLAI
(
	MAHD CHAR(10),
	NGAYBAN NVARCHAR(15),
	MANV CHAR(10),
	TENNV NVARCHAR(30),
	MAKH CHAR(10),
	TENKH NVARCHAR(30),
	DIACHI NVARCHAR(50),
	DT NVARCHAR(15),
	MAHANG CHAR(10),
	TENHANG NVARCHAR(100),
	SOLUONG INT,
	DONGIA FLOAT,
	GIAMGIA FLOAT,
	THANHTIEN Float,
	primary key(MAHD),
	FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MAKH) REFERENCES KHACH(MAKH),
	FOREIGN KEY(MAHANG) REFERENCES HANG(MAHANG),
)
alter table BIENLAI
alter column THANHTIEN MONEY
CREATE TABLE GIASANPHAM
(
	MAGIA CHAR(10) NOT NULL,
	MAHANG CHAR(10),
	TENHANG NVARCHAR(100),
	NSX NVARCHAR(20),
	GIA NVARCHAR(20)
	PRIMARY KEY(MAGIA),
	FOREIGN KEY(MAHANG) REFERENCES HANG(MAHANG)
)
insert into GIASANPHAM values('MG01','MH01',N'Máy Lanh DAIKIN Inverter','20/12/2000',29500000)
insert into GIASANPHAM values('MG02','MH02',N'Máy lạnh âm trần Daikin','19/12/2000',37200000)
insert into GIASANPHAM values('MG03','MH03',N'Máy Lạnh TOSHIBA Inverter 1.5 HP','18/12/2000',35800000)
insert into GIASANPHAM values('MG04','MH04',N'Máy Lạnh Tủ Đứng Daikin','17/12/2000',29500000)
insert into GIASANPHAM values('MG05','MH05',N'Máy Lạnh DAIKIN 2.0','16/12/2000',16790000)
insert into GIASANPHAM values('MG06','MH06',N'Máy Lạnh TOSHIBA Inverter 1.0 HP','15/12/2000',11490000)
insert into GIASANPHAM values('MG07','MH07',N'Máy lạnh Toshiba Inverter 2.0 HP','14/12/2000',18890000)
insert into GIASANPHAM values('MG08','MH08',N'Máy Lạnh TOSHIBA Inverter 1.0 HP','13/12/2000',18000000)
drop table BIENLAI
insert into DANGNHAP values(N'SonNguyen','123456')
insert into CHATLIEU values('CL01',N'Sắt')
insert into CHATLIEU values('CL02',N'Nhựa')
insert into CHATLIEU values('CL03',N'Bạc')
insert into CHATLIEU values('CL04',N'Vàng')
set dateformat DMY
insert into NHANVIEN values('NV01',N'Nguyễn Thanh Minh Sơn','Nam',N'140 Lê Trọng Tấn',0931857039,'21-10-2000')
insert into NHANVIEN values('NV02',N'Nguyễn Thành Tín','Nam',N'140 Lê Trọng Tấn',0123456789,'22-10-2000')
insert into NHANVIEN values('NV03',N'Nguyễn Minh Hải','Nam',N'140 Lê Trọng Tấn',0123456789,'23-10-2000')
select * from NHANVIEN

insert into KHACH values('KH01',N'Nguyễn Văn A',N'140 Lê Trọng Tấn','0987654321')
insert into KHACH values('KH02',N'Nguyễn Văn B',N'140 Lê Trọng Tấn','0987654321')
insert into KHACH values('KH03',N'Nguyễn Văn C',N'140 Lê Trọng Tấn','0987654321')
insert into KHACH values('KH04',N'Nguyễn Văn D',N'140 Lê Trọng Tấn','0987654321')

insert into HANG values('MH01',N'Máy Lanh DAIKIN Inverter','CL01',10,5000000,29500000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_16369_1.PNG',N'Công suất Làm lạnh 20,500 BTU, thể tích phòng sử dụng 100m3, nhãn năng lượng tiết kiệm điện và sản xuất tại Việt Nam')
insert into HANG values('MH02',N'Máy lạnh âm trần Daikin','CL01',15,5000000,37200000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\fcf-1.jpg',N'1 chiều – 36.000BTU – 3 pha – gas R410a Thổi gió 360 độ làm lạnh nhanh, thoải mái dễ chịuDễ dàng sử dụng, bảo dưỡng định kỳXuất xứ: Chính hãng Thái LanBảo hành: Máy 1 năm, máy nén 5 năm')
insert into HANG values('MH03',N'Máy Lạnh TOSHIBA Inverter 1.5 HP','CL02',20,5000000,12490000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_15390_1.PNG',N'Công suất: 11.900 BTU/h Công nghệ Hybrid Inverter tiết kiệm 35% điện năng Công nghệ chống bám bẩn Magic Coil Công nghê tinh lọc không khí IAQ')
insert into HANG values('MH04',N'Máy Lạnh Tủ Đứng Daikin','CL03',25,5000000,35800000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\may-lanh-tu-dung-daikin-fvrn.jpg',N'1 chiều – 42.000 Btu/h (5.5 Hp) – Gas R410a – 3 pha Thiết kế hiện đại, dễ sử dụng Nhỏ gọn, làm lạnh nhanh Xuất xứ: Malaysia Bảo hành: 12 tháng')
insert into HANG values('MH05',N'Máy Lạnh DAIKIN 2.0','CL02',30,5000000,16790000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_12727_1.PNG',N'Công suất: 17.100 BTU/h Công nghệ Hybrid Inverter tiết kiệm 35% điện năng Công nghệ chống bám bẩn Magic Coil Công nghê tinh lọc không khí IAQ')
insert into HANG values('MH06',N'Máy Lạnh TOSHIBA Inverter 1.0 HP','CL01',35,5000000,11490000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_15391_1.PNG',N'Công suất: 9000 BTU/h Công nghệ Hybrid Inverter tiết kiệm 35% điện năng Công nghệ chống bám bẩn Magic Coil Công nghê tinh lọc không khí IAQ')
insert into HANG values('MH07',N'Máy lạnh Toshiba Inverter 2.0 HP','CL03',40,5000000,18890000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_16361_1.PNG',N'Công suất: 17900 BTU/h Công nghệ Hybrid Inverter tiết kiệm 35% điện năng Công nghệ chống bám bẩn Magic Coil Công nghê tinh lọc không khí IAQ')
insert into HANG values('MH08',N'Máy Lạnh TOSHIBA Inverter 1.0 HP','CL02',45,5000000,18000000,'C:\Users\DELL\Desktop\DoAnFULL\DoAnFULL\Resources\product_15858_1.PNG',N'Công suất: 9000 BTU/h Công nghệ Hybrid Inverter tiết kiệm 35% điện năng Công nghệ chống bám bẩn Magic Coil Công nghê tinh lọc không khí IAQ')

insert into HDBANHANG values('HD01','NV01','14-12-2020','KH01',29500000)
insert into HDBANHANG values('HD02','NV02','15-12-2020','KH02',37200000)
insert into HDBANHANG values('HD03','NV03','14-12-2020','KH04',35800000)
insert into HDBANHANG values('HD04','NV01','13-12-2020','KH03',18000000)

insert into CHITIETHDBANHANG values('HD01','MH01',1,29500000,10,29500000*(1-0.1))
insert into CHITIETHDBANHANG values('HD02','MH02',2,2*37200000,15,2*37200000*(1-0.15))
insert into CHITIETHDBANHANG values('HD03','MH04',1,35800000,5,35800000*(1-0.05))
insert into CHITIETHDBANHANG values('HD04','MH08',1,18000000,3,18000000*(1-0.03))

insert into BIENLAI values('HD01','14-12-2020','NV01',N'Nguyễn Thanh Minh Sơn','KH01',N'Nguyễn Văn A',N'140 Lê Trọng Tấn','0987654321','MH01',N'Máy Lanh DAIKIN Inverter',1,29500000,10,29500000*(1-0.1))
insert into BIENLAI values('HD02','14-12-2020','NV02',N'Nguyễn Thành Tín','KH02',N'Nguyễn Văn B',N'140 Lê Trọng Tấn','0987654321','MH01',N'Máy Lanh DAIKIN Inverter',1,29500000,10,29500000*(1-0.1))
insert into BIENLAI values('HD03','14-12-2020','NV03',N'Nguyễn Minh Hải','KH03',N'Nguyễn Văn C',N'140 Lê Trọng Tấn','0987654321','MH01',N'Máy Lanh DAIKIN Inverter',1,29500000,10,29500000*(1-0.1))