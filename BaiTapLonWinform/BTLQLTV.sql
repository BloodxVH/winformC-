use master
go
create database MHHDL_DoAnQLTV
go
use MHHDL_DoAnQLTV

-- Tạo bảng Độc Giả
create table tblDocGia
(
	MaDG varchar(10) constraint pk_tblDocGia primary key,
	TenDG nvarchar(30),
	GioiTinhDG nvarchar(5),
	NgaySinhDG varchar(10),
	SDTDG int,
	DiaChiDG nvarchar(50),
	LoaiDG nvarchar(20),
	GhiChu nvarchar(30),
	TenTaiKhoanDG varchar(10),
	MatKhauDG varchar(20),
)

-- drop table tblDocGia

-- Tạo bảng Sách
create table tblSach
(
	MaSach varchar(10) constraint pk_tblSach primary key,
	TenSach nvarchar(50),
	ChuDe nvarchar(30),
	TacGia nvarchar(30),
	NXB nvarchar(30),
	NamXB int,
	SLNhap int,
	DonGia int,
	TinhTrang nvarchar(20),
	Ghichu nvarchar(30),
)
--drop table tblSach

-- Tạo bản Mượn Trả
create table tblHSPhieuMuon
(
	MaPhieu varchar(10),
	MaDG varchar(10),
	MaSach varchar(10),
	NgayMuon nvarchar(10),
	NgayTra nvarchar(10),
	SLMuon int,
	TinhTrang nvarchar(20),
	GhiChu nvarchar(75),
	constraint pk_tblMuonTra primary key(MaPhieu),
	constraint fk_tblMuonTra_tblDocGia foreign key(MaDG) references tblDocGia(MaDG),
	constraint fk_tblMuonTra_tblSach foreign key(MaSach) references tblSach(MaSach),
)
--drop table tblHSPhieuMuon

-- Tạo bảng Tài khoản thủ thư
create table tblThuThu
(
	MaTT varchar(10) constraint pk_tblThuThu primary key,
	TenTT nvarchar(30),
	GioiTinhTT nvarchar(5),
	NgaySinhTT varchar(10),
	SDTTT int,
	DiaChiTT nvarchar(50),
	GhiChu nvarchar(30),
	TenTaiKhoanTT varchar(10),
	MatKhauTT varchar(20),
)
--drop table tblThuThu

-- Chèn dữ liệu bảng tblDocGia
insert into tblDocGia values ('DG001',N'Vũ Đình Cần',N'Nam','15/06/1995','0974633324',N'115 Lê Đức Thọ, Gò Vấp',N'Sinh viên','...','DG001','123')
insert into tblDocGia values ('DG002',N'Huỳnh Thanh Hải',N'Nam','14/04/1996','045693224',N'115 Nguyễn Oanh, Gò Vấp',N'Sinh viên','...','DG002','123')
insert into tblDocGia values ('DG003',N'Thiều Sỹ Tùng',N'Nam','15/01/1995','0978633224',N'115 Lê Văn Thọ, Gò Vấp',N'Sinh viên','...','DG003','123')
insert into tblDocGia values ('DG004',N'Trần Nam',N'Nam','11/03/1994','0974551224',N'115 Hồ Thị Hương, Tân Bình',N'Sinh viên','...','DG004','123')
insert into tblDocGia values ('DG005',N'Nguyễn Trãi',N'Nam','23/10/1995','0974688824',N'119 Lê Đức Thọ, Gò Vấp',N'Sinh viên','...','DG005','123')
insert into tblDocGia values ('DG006',N'Nguyễn Xuân Phúc',N'Nam','15/10/1995','0974693111',N'113 Lê Duẩn, Q1',N'Sinh viên','...','DG006','123')
insert into tblDocGia values ('DG007',N'Phạm Nguyễn Gia Hân',N'Nữ','20/11/1993','033393224',N'784 Nguyễn Kiệm, Gò Vấp',N'Sinh viên','...','DG007','123')
insert into tblDocGia values ('DG008',N'Lê Chí Trung',N'Nam','08/03/1995','0974697754',N'988 Quang Trung, Gò Vấp',N'Sinh viên','...','DG008','123')
insert into tblDocGia values ('DG009',N'Lê Nguyễn Hồng Ngọc',N'Nữ','20/11/1995','0974694444',N'115 QL1, Q12',N'Sinh viên','...','DG009','123')
insert into tblDocGia values ('DG010',N'Nguyễn Vũ Hoàng',N'Nam','15/01/1990','0865693224',N'111 Hà Huy Giáp, Q12',N'Sinh viên','...','DG010','123')

-- Chèn dữ liệu bảng tblSach
insert into tblSach values ('MS001',N'Lập trình Windown',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2000','100','50000',N'Mới','...')
insert into tblSach values ('MS002',N'Lập trình Web',N'Lập trình',N'Lê Hồng Nhân',N'NXB Giáo Dục','2001','100','50000',N'Mới','...')
insert into tblSach values ('MS003',N'Lập trình HDT',N'Lập trình',N'Nguyễn Đức Phương',N'NXB Hồng Bàng','2002','100','30000',N'Mới','...')
insert into tblSach values ('MS004',N'Lập trình SQL',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2004','100','40000',N'Mới','...')
insert into tblSach values ('MS005',N'Thiết bị công nghệ hiện đại',N'Công nghệ',N'Trần Xuân Bách',N'NXB Thanh Niên','2004','100','60000',N'Mới','...')
insert into tblSach values ('MS006',N'Khoa học quanh ta',N'Công nghệ',N'Trần Văn Chung',N'NXB Giáo Dục','2002','100','40000',N'Mới','...')
insert into tblSach values ('MS007',N'Úng dụng công nghệ',N'Công nghệ',N'Nguyễn Hoài Nhâm',N'NXB Hồng Bàng','2009','100','50000',N'Mới','...')
insert into tblSach values ('MS008',N'Bạn và Tôi',N'Tiểu thuyết',N'Lệ Thu',N'NXB Trẻ','2007','100','50000',N'Mới','...')
insert into tblSach values ('MS009',N'Ngày Ấy',N'Tiểu thuyết',N'Nguyễn Hoài Nhớ',N'NXB Thanh Niên','2010','100','40000',N'Mới','...')
insert into tblSach values ('MS010',N'Tôi đi tìm tôi',N'Tiểu thuyết',N'Phạm Đức',N'NXB Thanh Niên','2004','100','20000',N'Mới','...')

--delete from tblSach

-- Chèn dữ liệu bảng tblHSPhieuMuon
insert into tblHSPhieuMuon values ('MP001','DG001','MS001','01/01/2017','21/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP002','DG001','MS002','01/01/2017','21/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2016','22/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2017','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2017','24/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2017','12/01/2017','1',N'Mới','...')







-- có ngày hẹn trả
-- Chèn dữ liệu bảng tblHSPhieuMuon
/*
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2016','22/12/2016','22/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2017','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2017','24/12/2016','24/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2017','12/01/2017','12/01/2017','1',N'Mới','...')
--delete from tblMuonTra
*/

-- Chèn dữ liệu bảng tblDangNhap
insert into tblThuThu values ('TT001',N'Vũ Đình Cần',N'Nam','15/06/1995','0974633324',N'115 Lê Đức Thọ, Gò Vấp','...','TT001','123')
insert into tblThuThu values ('TT002',N'Nguyễn Như Trãi',N'Nam','15/06/1995','0974633324',N'115 Lê Đức Thọ, Gò Vấp','...','TT002','123')
insert into tblThuThu values ('TT003',N'Thiều Sỹ Tùng',N'Nam','15/06/1995','0974633324',N'115 Lê Đức Thọ, Gò Vấp','...','TT003','123')


