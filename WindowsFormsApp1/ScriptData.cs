using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    public class ScriptData
    {
        public StringBuilder CreateDataBase = new StringBuilder();
        public StringBuilder CreateTable1 = new StringBuilder();
        public StringBuilder CreateTable2 = new StringBuilder();
        public StringBuilder CreateTable3 = new StringBuilder();
        public StringBuilder CreateTable4 = new StringBuilder();
        public StringBuilder CreateTable5 = new StringBuilder();
        public StringBuilder CreateTable6 = new StringBuilder();
        public StringBuilder CreateTable7 = new StringBuilder();
        public StringBuilder CreateTable8 = new StringBuilder();
        public StringBuilder CreateTable9 = new StringBuilder();
        public StringBuilder CreateTable10 = new StringBuilder();
        public StringBuilder CreateTable11 = new StringBuilder();
        public StringBuilder CreateTable12 = new StringBuilder();
        public StringBuilder CreateTable13 = new StringBuilder();
        public StringBuilder CreateTable14 = new StringBuilder();
        public StringBuilder CreateTable15 = new StringBuilder();
        public StringBuilder CreateTable16 = new StringBuilder();

        public StringBuilder CreateFunction1 = new StringBuilder();
        public StringBuilder CreateFunction2 = new StringBuilder();
        public StringBuilder CreateFunction3 = new StringBuilder();
        public StringBuilder CreateFunction4 = new StringBuilder();
        public StringBuilder CreateFunction5 = new StringBuilder();


        public StringBuilder CreateForeignKey1 = new StringBuilder();
        public StringBuilder CreateForeignKey2 = new StringBuilder();
        public StringBuilder CreateForeignKey3 = new StringBuilder();
        public StringBuilder CreateForeignKey4 = new StringBuilder();
        public StringBuilder CreateForeignKey5 = new StringBuilder();
        public StringBuilder CreateForeignKey6 = new StringBuilder();
        public StringBuilder CreateForeignKey7 = new StringBuilder();
        public StringBuilder CreateForeignKey8 = new StringBuilder();
        public StringBuilder CreateForeignKey9 = new StringBuilder();
        public StringBuilder CreateForeignKey10 = new StringBuilder();
        public StringBuilder CreateForeignKey11 = new StringBuilder();
        public StringBuilder CreateForeignKey12 = new StringBuilder();
        public StringBuilder CreateForeignKey13 = new StringBuilder();

        public ScriptData()
        {
            CreateDataBase.Append("IF  NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = N'QL_TT_CanBo') \n");
            CreateDataBase.Append("    BEGIN \n");
            CreateDataBase.Append("        CREATE DATABASE [QL_TT_CanBo] \n");
            CreateDataBase.Append(" \n");
            CreateDataBase.Append("    END;");

            CreateTable1.Append("CREATE TABLE [dbo].[CanBo]( \n");
            CreateTable1.Append("	[maCB] [varchar](6) NOT NULL, \n");
            CreateTable1.Append("	[maQH] [varchar](6) NOT NULL, \n");
            CreateTable1.Append("	[maDV] [varchar](6) NOT NULL, \n");
            CreateTable1.Append("	[maCV] [varchar](6) NULL, \n");
            CreateTable1.Append("	[maCVD] [varchar](6) NULL, \n");
            CreateTable1.Append("	[hoTen] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[biDanh] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[gioiTinh] [nvarchar](10) NULL, \n");
            CreateTable1.Append("	[ngaySinh] [date] NULL, \n");
            CreateTable1.Append("	[danToc] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[tonGiao] [nvarchar](10) NULL, \n");
            CreateTable1.Append("	[quocTich] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[soCMND] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[dienThoai] [nvarchar](11) NULL, \n");
            CreateTable1.Append("	[email] [nvarchar](300) NULL, \n");
            CreateTable1.Append("	[donViTD] [nvarchar](300) NULL, \n");
            CreateTable1.Append("	[ngayVaoNganh] [date] NULL, \n");
            CreateTable1.Append("	[ngayVaoDoan] [date] NULL, \n");
            CreateTable1.Append("	[noiSinh] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[queQuan] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[noiThuongTru] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[noiTamTru] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[tinhTrangSK] [nvarchar](max) NULL, \n");
            CreateTable1.Append("	[nhomMau] [nvarchar](3) NULL, \n");
            CreateTable1.Append("	[chieuCao] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[canNang] [nvarchar](50) NULL, \n");
            CreateTable1.Append("	[TTHonNhan] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[gdPhoThong] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[gdNgheNghiep] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[gdDH] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[hocHam] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[lyLuanCT] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[ngoaiNgu] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[tinHoc] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[tiengDanToc] [nvarchar](100) NULL, \n");
            CreateTable1.Append("	[luongCB] [float] NULL, \n");
            CreateTable1.Append("	[ngayVDang] [date] NULL, \n");
            CreateTable1.Append("	[noiVDang] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[nguoiGT] [nvarchar](155) NULL, \n");
            CreateTable1.Append("	[TCCSD] [nvarchar](255) NULL, \n");
            CreateTable1.Append("	[ghiChu] [nvarchar](max) NULL, \n");
            CreateTable1.Append("	[pathPic] [nvarchar](max) NULL, \n");
            CreateTable1.Append("	[avatar] [image] NULL, \n");
            CreateTable1.Append("	[tgBoNhiem] [date] NULL, \n");
            CreateTable1.Append(" CONSTRAINT [PK_CanBo] PRIMARY KEY CLUSTERED \n");
            CreateTable1.Append("( \n");
            CreateTable1.Append("	[maCB] ASC \n");
            CreateTable1.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable1.Append(") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]");

            CreateTable2.Append("CREATE TABLE [dbo].[ChucVu]( \n");
            CreateTable2.Append("	[maCV] [varchar](6) NOT NULL, \n");
            CreateTable2.Append("	[tenCV] [nvarchar](50) NULL, \n");
            CreateTable2.Append("	[mienGiam] [float] NULL, \n");
            CreateTable2.Append("	[ghiChu] [nvarchar](255) NULL, \n");
            CreateTable2.Append(" CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED \n");
            CreateTable2.Append("( \n");
            CreateTable2.Append("	[maCV] ASC \n");
            CreateTable2.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable2.Append(") ON [PRIMARY]");

            CreateTable3.Append("CREATE TABLE [dbo].[ChucVuDang]( \n");
            CreateTable3.Append("	[maCV] [varchar](6) NOT NULL, \n");
            CreateTable3.Append("	[tenCV] [nvarchar](50) NULL, \n");
            CreateTable3.Append("	[mienGiam] [float] NULL, \n");
            CreateTable3.Append("	[ghiChu] [nvarchar](255) NULL, \n");
            CreateTable3.Append(" CONSTRAINT [PK_ChucVuDang] PRIMARY KEY CLUSTERED \n");
            CreateTable3.Append("( \n");
            CreateTable3.Append("	[maCV] ASC \n");
            CreateTable3.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable3.Append(") ON [PRIMARY]");


            CreateTable4.Append("CREATE TABLE [dbo].[DonVi]( \n");
            CreateTable4.Append("	[maDV] [varchar](6) NOT NULL, \n");
            CreateTable4.Append("	[tenDV] [nvarchar](50) NULL, \n");
            CreateTable4.Append("	[sdt] [nvarchar](11) NULL, \n");
            CreateTable4.Append("	[ghiChu] [nvarchar](255) NULL, \n");
            CreateTable4.Append(" CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED \n");
            CreateTable4.Append("( \n");
            CreateTable4.Append("	[maDV] ASC \n");
            CreateTable4.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable4.Append(") ON [PRIMARY]");


            CreateTable5.Append("CREATE TABLE [dbo].[HoanCanhGD]( \n");
            CreateTable5.Append("	[maHCGD] [varchar](6) NOT NULL, \n");
            CreateTable5.Append("	[maCB] [varchar](6) NULL, \n");
            CreateTable5.Append("	[quanHe] [nvarchar](50) NULL, \n");
            CreateTable5.Append("	[hoTen] [nvarchar](100) NULL, \n");
            CreateTable5.Append("	[namSinh] [int] NULL, \n");
            CreateTable5.Append("	[noiSinh] [nvarchar](255) NULL, \n");
            CreateTable5.Append("	[queQuan] [nvarchar](255) NULL, \n");
            CreateTable5.Append("	[HKTT] [nvarchar](255) NULL, \n");
            CreateTable5.Append("	[choOHN] [nvarchar](255) NULL, \n");
            CreateTable5.Append("	[danToc] [nvarchar](50) NULL, \n");
            CreateTable5.Append("	[tonGiao] [nvarchar](10) NULL, \n");
            CreateTable5.Append("	[ngheNghiep] [nvarchar](100) NULL, \n");
            CreateTable5.Append("	[qtrHD] [nvarchar](4000) NULL, \n");
            CreateTable5.Append("	[tinhTrang] [nvarchar](50) NULL, \n");
            CreateTable5.Append("	[thaiDoTT] [nvarchar](500) NULL, \n");
            CreateTable5.Append(" CONSTRAINT [PK_HoanCanhGD] PRIMARY KEY CLUSTERED \n");
            CreateTable5.Append("( \n");
            CreateTable5.Append("	[maHCGD] ASC \n");
            CreateTable5.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable5.Append(") ON [PRIMARY]");

            CreateTable6.Append("CREATE TABLE [dbo].[Huyen]( \n");
            CreateTable6.Append("	[maqh] [varchar](6) NOT NULL, \n");
            CreateTable6.Append("	[name] [nvarchar](100) NULL, \n");
            CreateTable6.Append("	[loai] [nvarchar](30) NULL, \n");
            CreateTable6.Append("	[matp] [varchar](6) NOT NULL, \n");
            CreateTable6.Append(" CONSTRAINT [PK_Huyen] PRIMARY KEY CLUSTERED \n");
            CreateTable6.Append("( \n");
            CreateTable6.Append("	[maqh] ASC \n");
            CreateTable6.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable6.Append(") ON [PRIMARY]");

            CreateTable7.Append("CREATE TABLE [dbo].[KhenThuong]( \n");
            CreateTable7.Append("	[maKT] [varchar](6) NOT NULL, \n");
            CreateTable7.Append("	[tenKT] [nvarchar](500) NULL, \n");
            CreateTable7.Append("	[capQD] [nvarchar](50) NULL, \n");
            CreateTable7.Append("	[tg] [date] NULL, \n");
            CreateTable7.Append(" CONSTRAINT [PK_KhenThuong] PRIMARY KEY CLUSTERED \n");
            CreateTable7.Append("( \n");
            CreateTable7.Append("	[maKT] ASC \n");
            CreateTable7.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable7.Append(") ON [PRIMARY]");

            CreateTable8.Append("CREATE TABLE [dbo].[KiLuat]( \n");
            CreateTable8.Append("	[maKL] [varchar](6) NOT NULL, \n");
            CreateTable8.Append("	[dieu] [int] NULL, \n");
            CreateTable8.Append("	[khoan] [int] NULL, \n");
            CreateTable8.Append("	[capQD] [nvarchar](100) NULL, \n");
            CreateTable8.Append("	[tenKL] [nvarchar](500) NULL, \n");
            CreateTable8.Append("	[mucKL] [nvarchar](50) NULL, \n");
            CreateTable8.Append("	[hinhPhat] [nvarchar](100) NULL, \n");
            CreateTable8.Append("	[tg] [date] NULL, \n");
            CreateTable8.Append("	[hienTrang] [nvarchar](50) NULL, \n");
            CreateTable8.Append("	[ghiChu] [nvarchar](400) NULL, \n");
            CreateTable8.Append(" CONSTRAINT [PK_KiLuat] PRIMARY KEY CLUSTERED \n");
            CreateTable8.Append("( \n");
            CreateTable8.Append("	[maKL] ASC \n");
            CreateTable8.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable8.Append(") ON [PRIMARY]");

            CreateTable9.Append("CREATE TABLE [dbo].[KL_CB]( \n");
            CreateTable9.Append("	[maKL] [varchar](6) NULL, \n");
            CreateTable9.Append("	[maCB] [varchar](6) NULL \n");
            CreateTable9.Append(") ON [PRIMARY]");

            CreateTable10.Append("CREATE TABLE [dbo].[KT_CB]( \n");
            CreateTable10.Append("	[maKT] [varchar](6) NULL, \n");
            CreateTable10.Append("	[maCB] [varchar](6) NULL \n");
            CreateTable10.Append(") ON [PRIMARY]");

            CreateTable11.Append("CREATE TABLE [dbo].[QuanHam]( \n");
            CreateTable11.Append("	[maQH] [varchar](6) NOT NULL, \n");
            CreateTable11.Append("	[tenQH] [nvarchar](50) NULL, \n");
            CreateTable11.Append("	[hsLuong] [float] NULL, \n");
            CreateTable11.Append(" CONSTRAINT [PK_QuanHam] PRIMARY KEY CLUSTERED \n");
            CreateTable11.Append("( \n");
            CreateTable11.Append("	[maQH] ASC \n");
            CreateTable11.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable11.Append(") ON [PRIMARY]");

            CreateTable12.Append("CREATE TABLE [dbo].[QuaTrinhCongTac]( \n");
            CreateTable12.Append("	[maQT] [varchar](6) NOT NULL, \n");
            CreateTable12.Append("	[maCB] [varchar](6) NOT NULL, \n");
            CreateTable12.Append("	[chucVu] [varchar](6) NULL, \n");
            CreateTable12.Append("	[donVi] [varchar](6) NULL, \n");
            CreateTable12.Append("	[nhiemVu] [nvarchar](255) NULL, \n");
            CreateTable12.Append("	[tuNgay] [date] NULL, \n");
            CreateTable12.Append("	[denNgay] [date] NULL, \n");
            CreateTable12.Append(" CONSTRAINT [PK_QuaTrinhCongTac] PRIMARY KEY CLUSTERED \n");
            CreateTable12.Append("( \n");
            CreateTable12.Append("	[maQT] ASC \n");
            CreateTable12.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable12.Append(") ON [PRIMARY]");

            CreateTable13.Append("CREATE TABLE [dbo].[taikhoan]( \n");
            CreateTable13.Append("	[us] [varchar](50) NOT NULL, \n");
            CreateTable13.Append("	[pwd] [nvarchar](50) NULL, \n");
            CreateTable13.Append("	[role] [tinyint] NULL, \n");
            CreateTable13.Append(" CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED \n");
            CreateTable13.Append("( \n");
            CreateTable13.Append("	[us] ASC \n");
            CreateTable13.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable13.Append(") ON [PRIMARY]");

            CreateTable14.Append("CREATE TABLE [dbo].[TinhTP]( \n");
            CreateTable14.Append("	[matp] [varchar](6) NOT NULL, \n");
            CreateTable14.Append("	[name] [nvarchar](100) NULL, \n");
            CreateTable14.Append("	[loai] [nvarchar](50) NULL, \n");
            CreateTable14.Append(" CONSTRAINT [PK_TinhTP] PRIMARY KEY CLUSTERED \n");
            CreateTable14.Append("( \n");
            CreateTable14.Append("	[matp] ASC \n");
            CreateTable14.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable14.Append(") ON [PRIMARY]");

            CreateTable15.Append("CREATE TABLE [dbo].[VanBangChungChi]( \n");
            CreateTable15.Append("	[maVBCC] [varchar](6) NOT NULL, \n");
            CreateTable15.Append("	[maCB] [varchar](6) NULL, \n");
            CreateTable15.Append("	[tenCC] [nvarchar](255) NULL, \n");
            CreateTable15.Append("	[pathPic] [varchar](max) NULL, \n");
            CreateTable15.Append("	[picVBCC] [image] NULL, \n");
            CreateTable15.Append(" CONSTRAINT [PK_VanBangChungChi] PRIMARY KEY CLUSTERED \n");
            CreateTable15.Append("( \n");
            CreateTable15.Append("	[maVBCC] ASC \n");
            CreateTable15.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable15.Append(") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]");

            CreateTable16.Append("CREATE TABLE [dbo].[Xa]( \n");
            CreateTable16.Append("	[xaid] [varchar](6) NOT NULL, \n");
            CreateTable16.Append("	[name] [nvarchar](50) NULL, \n");
            CreateTable16.Append("	[loai] [nvarchar](50) NULL, \n");
            CreateTable16.Append("	[maqh] [varchar](6) NOT NULL, \n");
            CreateTable16.Append(" CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED \n");
            CreateTable16.Append("( \n");
            CreateTable16.Append("	[xaid] ASC \n");
            CreateTable16.Append(")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] \n");
            CreateTable16.Append(") ON [PRIMARY]");

            CreateFunction1.Append("CREATE function [dbo].[fCanBo_BoNhiemLai]() \n");
            CreateFunction1.Append("RETURNS table \n");
            CreateFunction1.Append("as RETURN select hoTen,ngaySinh,DonVi.tenDV,ChucVu.tenCV,tgBoNhiem,queQuan from CanBo inner join DonVi on CanBo.maDV=DonVi.maDV inner join ChucVu on CanBo.maCV=ChucVu.maCV where datediff(year,tgBoNhiem,GETDATE()) > 5 and CanBo.maCV!='K'");

            CreateFunction2.Append("create function [dbo].[fCanBo_DonVi]() \n");
            CreateFunction2.Append("returns table \n");
            CreateFunction2.Append("as return select hoTen,gioiTinh,ngaySinh,ChucVu.tenCV,queQuan,dienThoai from CanBo inner join DonVi on CanBo.maDV = DonVi.maDV inner join ChucVu on CanBo.maCV=ChucVu.maCV");

            CreateFunction3.Append("create function [dbo].[fCanBo_NghiHuu]() \n");
            CreateFunction3.Append("RETURNS table \n");
            CreateFunction3.Append("as RETURN select hoTen,ngaySinh,DonVi.tenDV,datediff(year,ngaySinh,GETDATE()) as N'Tuoi',queQuan from CanBo inner join DonVi on CanBo.maDV=DonVi.maDV where (datediff(year,ngaySinh,GETDATE()) > 52 and (((maQH='TU' or maQH = 'TRU'or maQH = 'THU'or maQH = 'DU') and gioiTinh = 'Nam') or((maQH='TU' or maQH = 'TRU' or maQH = 'THU' or maQH = 'DU' or maQH = 'TT' or maQH = 'TRT' ) and gioiTinh = N'Nữ'))) or (datediff(year,ngaySinh,GETDATE()) > 54 and (((maQH='TT' or maQH = 'TRT') and gioiTinh = 'Nam') or((maQH='TTg' or maQH = 'TRTg' or maQH = 'THTg' or maQH = 'DTg' or maQH = 'THT') and gioiTinh = N'Nữ'))) or (datediff(year,ngaySinh,GETDATE()) > 57 and maQH='THT' and gioiTinh = 'Nam') or (datediff(year,ngaySinh,GETDATE()) > 59 and (maQH='DT' or maQH='TTg' or maQH = 'TRTg'or maQH = 'THTg'or maQH = 'DTg') and gioiTinh = 'Nam')");

            CreateFunction4.Append("create function [dbo].[fKiLuat_Dem]() \n");
            CreateFunction4.Append("returns table \n");
            CreateFunction4.Append("as return select DonVi.tenDV,count(KL_CB.maKL) as 'soKL' from CanBo inner join KL_CB on CanBo.maCB = KL_CB.maCB inner join DonVi on CanBo.maDV = DonVi.maDV group by DonVi.tenDV");

            CreateFunction5.Append("CREATE function [dbo].[fKiLuat_TheoDonVi]() \n");
            CreateFunction5.Append("returns table \n");
            CreateFunction5.Append("as return select CanBo.hoTen,DonVi.tenDV,CanBo.ngaySinh,CanBo.gioiTinh,QuanHam.tenQH,KiLuat.tenKL from CanBo inner join KL_CB on CanBo.maCB = KL_CB.maCB inner join DonVi on CanBo.maDV = DonVi.maDV inner join KiLuat on KL_CB.maKL=KiLuat.maKL inner join QuanHam on CanBo.maQH=QuanHam.maQH");

            CreateForeignKey1.Append("ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_ChucVu] FOREIGN KEY([maCV]) \n");
            CreateForeignKey1.Append("REFERENCES [dbo].[ChucVu] ([maCV]) \n");
            CreateForeignKey1.Append("ON UPDATE CASCADE");

            CreateForeignKey2.Append("ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_ChucVuDang] FOREIGN KEY([maCVD]) \n");
            CreateForeignKey2.Append("REFERENCES [dbo].[ChucVuDang] ([maCV]) \n");
            CreateForeignKey2.Append("ON UPDATE CASCADE");

            CreateForeignKey3.Append("ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_DonVi] FOREIGN KEY([maDV]) \n");
            CreateForeignKey3.Append("REFERENCES [dbo].[DonVi] ([maDV]) \n");
            CreateForeignKey3.Append("ON UPDATE CASCADE");

            CreateForeignKey4.Append("ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_QH] FOREIGN KEY([maQH]) \n");
            CreateForeignKey4.Append("REFERENCES [dbo].[QuanHam] ([maQH]) \n");
            CreateForeignKey4.Append("ON UPDATE CASCADE");

            CreateForeignKey5.Append("ALTER TABLE [dbo].[HoanCanhGD]  WITH CHECK ADD  CONSTRAINT [FK_HoanCanhGD_CanBo] FOREIGN KEY([maCB]) \n");
            CreateForeignKey5.Append("REFERENCES [dbo].[CanBo] ([maCB])");

            CreateForeignKey6.Append("ALTER TABLE [dbo].[Huyen]  WITH CHECK ADD  CONSTRAINT [FK_Huyen_TinhTP] FOREIGN KEY([matp]) \n");
            CreateForeignKey6.Append("REFERENCES [dbo].[TinhTP] ([matp])");

            CreateForeignKey7.Append("ALTER TABLE [dbo].[KL_CB]  WITH CHECK ADD  CONSTRAINT [FK_KL_CB_CanBo] FOREIGN KEY([maCB]) \n");
            CreateForeignKey7.Append("REFERENCES [dbo].[CanBo] ([maCB]) \n");
            CreateForeignKey7.Append("ON UPDATE CASCADE \n");
            CreateForeignKey7.Append("ON DELETE CASCADE");

            CreateForeignKey8.Append("ALTER TABLE [dbo].[KL_CB]  WITH CHECK ADD  CONSTRAINT [FK_KL_CB_KiLuat] FOREIGN KEY([maKL]) \n");
            CreateForeignKey8.Append("REFERENCES [dbo].[KiLuat] ([maKL]) \n");
            CreateForeignKey8.Append("ON UPDATE CASCADE \n");
            CreateForeignKey8.Append("ON DELETE CASCADE");

            CreateForeignKey9.Append("ALTER TABLE [dbo].[KT_CB]  WITH CHECK ADD  CONSTRAINT [FK_KT_CB_CanBo] FOREIGN KEY([maCB]) \n");
            CreateForeignKey9.Append("REFERENCES [dbo].[CanBo] ([maCB]) \n");
            CreateForeignKey9.Append("ON UPDATE CASCADE \n");
            CreateForeignKey9.Append("ON DELETE CASCADE");

            CreateForeignKey10.Append("ALTER TABLE [dbo].[KT_CB]  WITH CHECK ADD  CONSTRAINT [FK_KT_CB_KhenThuong] FOREIGN KEY([maKT]) \n");
            CreateForeignKey10.Append("REFERENCES [dbo].[KhenThuong] ([maKT]) \n");
            CreateForeignKey10.Append("ON UPDATE CASCADE \n");
            CreateForeignKey10.Append("ON DELETE CASCADE");

            CreateForeignKey11.Append("ALTER TABLE [dbo].[QuaTrinhCongTac]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhCongTac_CanBo] FOREIGN KEY([maCB]) \n");
            CreateForeignKey11.Append("REFERENCES [dbo].[CanBo] ([maCB])");

            CreateForeignKey12.Append("ALTER TABLE [dbo].[VanBangChungChi]  WITH CHECK ADD  CONSTRAINT [FK_VanBangChungChi_CanBo] FOREIGN KEY([maCB]) \n");
            CreateForeignKey12.Append("REFERENCES [dbo].[CanBo] ([maCB]) \n");
            CreateForeignKey12.Append("ON UPDATE CASCADE \n");
            CreateForeignKey12.Append("ON DELETE CASCADE");

            CreateForeignKey13.Append("ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_Huyen] FOREIGN KEY([maqh]) \n");
            CreateForeignKey13.Append("REFERENCES [dbo].[Huyen] ([maqh])");

        }
    }
}
