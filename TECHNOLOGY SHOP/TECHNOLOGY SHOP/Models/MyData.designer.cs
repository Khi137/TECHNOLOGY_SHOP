﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TECHNOLOGY_SHOP.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
    using System.ComponentModel.DataAnnotations;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BanHang")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttb_DonHang(tb_DonHang instance);
    partial void Updatetb_DonHang(tb_DonHang instance);
    partial void Deletetb_DonHang(tb_DonHang instance);
    partial void Inserttb_DonHang_SanPham(tb_DonHang_SanPham instance);
    partial void Updatetb_DonHang_SanPham(tb_DonHang_SanPham instance);
    partial void Deletetb_DonHang_SanPham(tb_DonHang_SanPham instance);
    partial void Inserttb_HangSanPham(tb_HangSanPham instance);
    partial void Updatetb_HangSanPham(tb_HangSanPham instance);
    partial void Deletetb_HangSanPham(tb_HangSanPham instance);
    partial void Inserttb_LoaiSanPham(tb_LoaiSanPham instance);
    partial void Updatetb_LoaiSanPham(tb_LoaiSanPham instance);
    partial void Deletetb_LoaiSanPham(tb_LoaiSanPham instance);
    partial void Inserttb_SanPham(tb_SanPham instance);
    partial void Updatetb_SanPham(tb_SanPham instance);
    partial void Deletetb_SanPham(tb_SanPham instance);
    partial void Inserttb_TaiKhoan(tb_TaiKhoan instance);
    partial void Updatetb_TaiKhoan(tb_TaiKhoan instance);
    partial void Deletetb_TaiKhoan(tb_TaiKhoan instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BanHangConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_DonHang> tb_DonHangs
		{
			get
			{
				return this.GetTable<tb_DonHang>();
			}
		}
		
		public System.Data.Linq.Table<tb_DonHang_SanPham> tb_DonHang_SanPhams
		{
			get
			{
				return this.GetTable<tb_DonHang_SanPham>();
			}
		}
		
		public System.Data.Linq.Table<tb_HangSanPham> tb_HangSanPhams
		{
			get
			{
				return this.GetTable<tb_HangSanPham>();
			}
		}
		
		public System.Data.Linq.Table<tb_LoaiSanPham> tb_LoaiSanPhams
		{
			get
			{
				return this.GetTable<tb_LoaiSanPham>();
			}
		}
		
		public System.Data.Linq.Table<tb_SanPham> tb_SanPhams
		{
			get
			{
				return this.GetTable<tb_SanPham>();
			}
		}
		
		public System.Data.Linq.Table<tb_TaiKhoan> tb_TaiKhoans
		{
			get
			{
				return this.GetTable<tb_TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_DonHang")]
	public partial class tb_DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDonHang;
		
		private int _idTaiKhoan;
		
		private System.DateTime _ngayDat;
		
		private System.DateTime _ngayGiao;
		
		private EntitySet<tb_DonHang_SanPham> _tb_DonHang_SanPhams;
		
		private EntityRef<tb_TaiKhoan> _tb_TaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDonHangChanging(int value);
    partial void OnidDonHangChanged();
    partial void OnidTaiKhoanChanging(int value);
    partial void OnidTaiKhoanChanged();
    partial void OnngayDatChanging(System.DateTime value);
    partial void OnngayDatChanged();
    partial void OnngayGiaoChanging(System.DateTime value);
    partial void OnngayGiaoChanged();
    #endregion
		
		public tb_DonHang()
		{
			this._tb_DonHang_SanPhams = new EntitySet<tb_DonHang_SanPham>(new Action<tb_DonHang_SanPham>(this.attach_tb_DonHang_SanPhams), new Action<tb_DonHang_SanPham>(this.detach_tb_DonHang_SanPhams));
			this._tb_TaiKhoan = default(EntityRef<tb_TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idDonHang
		{
			get
			{
				return this._idDonHang;
			}
			set
			{
				if ((this._idDonHang != value))
				{
					this.OnidDonHangChanging(value);
					this.SendPropertyChanging();
					this._idDonHang = value;
					this.SendPropertyChanged("idDonHang");
					this.OnidDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTaiKhoan", DbType="Int NOT NULL")]
		public int idTaiKhoan
		{
			get
			{
				return this._idTaiKhoan;
			}
			set
			{
				if ((this._idTaiKhoan != value))
				{
					if (this._tb_TaiKhoan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._idTaiKhoan = value;
					this.SendPropertyChanged("idTaiKhoan");
					this.OnidTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDat", DbType="DateTime NOT NULL")]
		public System.DateTime ngayDat
		{
			get
			{
				return this._ngayDat;
			}
			set
			{
				if ((this._ngayDat != value))
				{
					this.OnngayDatChanging(value);
					this.SendPropertyChanging();
					this._ngayDat = value;
					this.SendPropertyChanged("ngayDat");
					this.OnngayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayGiao", DbType="DateTime NOT NULL")]
		public System.DateTime ngayGiao
		{
			get
			{
				return this._ngayGiao;
			}
			set
			{
				if ((this._ngayGiao != value))
				{
					this.OnngayGiaoChanging(value);
					this.SendPropertyChanging();
					this._ngayGiao = value;
					this.SendPropertyChanged("ngayGiao");
					this.OnngayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_DonHang_tb_DonHang_SanPham", Storage="_tb_DonHang_SanPhams", ThisKey="idDonHang", OtherKey="idDonHang")]
		public EntitySet<tb_DonHang_SanPham> tb_DonHang_SanPhams
		{
			get
			{
				return this._tb_DonHang_SanPhams;
			}
			set
			{
				this._tb_DonHang_SanPhams.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_TaiKhoan_tb_DonHang", Storage="_tb_TaiKhoan", ThisKey="idTaiKhoan", OtherKey="idTaiKhoan", IsForeignKey=true)]
		public tb_TaiKhoan tb_TaiKhoan
		{
			get
			{
				return this._tb_TaiKhoan.Entity;
			}
			set
			{
				tb_TaiKhoan previousValue = this._tb_TaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._tb_TaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tb_TaiKhoan.Entity = null;
						previousValue.tb_DonHangs.Remove(this);
					}
					this._tb_TaiKhoan.Entity = value;
					if ((value != null))
					{
						value.tb_DonHangs.Add(this);
						this._idTaiKhoan = value.idTaiKhoan;
					}
					else
					{
						this._idTaiKhoan = default(int);
					}
					this.SendPropertyChanged("tb_TaiKhoan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tb_DonHang_SanPhams(tb_DonHang_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_DonHang = this;
		}
		
		private void detach_tb_DonHang_SanPhams(tb_DonHang_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_DonHang_SanPham")]
	public partial class tb_DonHang_SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDonHang;
		
		private int _idSP;
		
		private int _soLuong;
		
		private decimal _donGia;
		
		private decimal _thanhTien;
		
		private EntityRef<tb_DonHang> _tb_DonHang;
		
		private EntityRef<tb_SanPham> _tb_SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDonHangChanging(int value);
    partial void OnidDonHangChanged();
    partial void OnidSPChanging(int value);
    partial void OnidSPChanged();
    partial void OnsoLuongChanging(int value);
    partial void OnsoLuongChanged();
    partial void OndonGiaChanging(decimal value);
    partial void OndonGiaChanged();
    partial void OnthanhTienChanging(decimal value);
    partial void OnthanhTienChanged();
    #endregion
		
		public tb_DonHang_SanPham()
		{
			this._tb_DonHang = default(EntityRef<tb_DonHang>);
			this._tb_SanPham = default(EntityRef<tb_SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idDonHang
		{
			get
			{
				return this._idDonHang;
			}
			set
			{
				if ((this._idDonHang != value))
				{
					if (this._tb_DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidDonHangChanging(value);
					this.SendPropertyChanging();
					this._idDonHang = value;
					this.SendPropertyChanged("idDonHang");
					this.OnidDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idSP
		{
			get
			{
				return this._idSP;
			}
			set
			{
				if ((this._idSP != value))
				{
					if (this._tb_SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidSPChanging(value);
					this.SendPropertyChanging();
					this._idSP = value;
					this.SendPropertyChanged("idSP");
					this.OnidSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuong", DbType="Int NOT NULL")]
		public int soLuong
		{
			get
			{
				return this._soLuong;
			}
			set
			{
				if ((this._soLuong != value))
				{
					this.OnsoLuongChanging(value);
					this.SendPropertyChanging();
					this._soLuong = value;
					this.SendPropertyChanged("soLuong");
					this.OnsoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_donGia", DbType="Decimal(18,0) NOT NULL")]
		public decimal donGia
		{
			get
			{
				return this._donGia;
			}
			set
			{
				if ((this._donGia != value))
				{
					this.OndonGiaChanging(value);
					this.SendPropertyChanging();
					this._donGia = value;
					this.SendPropertyChanged("donGia");
					this.OndonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhTien", DbType="Decimal(18,0) NOT NULL")]
		public decimal thanhTien
		{
			get
			{
				return this._thanhTien;
			}
			set
			{
				if ((this._thanhTien != value))
				{
					this.OnthanhTienChanging(value);
					this.SendPropertyChanging();
					this._thanhTien = value;
					this.SendPropertyChanged("thanhTien");
					this.OnthanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_DonHang_tb_DonHang_SanPham", Storage="_tb_DonHang", ThisKey="idDonHang", OtherKey="idDonHang", IsForeignKey=true)]
		public tb_DonHang tb_DonHang
		{
			get
			{
				return this._tb_DonHang.Entity;
			}
			set
			{
				tb_DonHang previousValue = this._tb_DonHang.Entity;
				if (((previousValue != value) 
							|| (this._tb_DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tb_DonHang.Entity = null;
						previousValue.tb_DonHang_SanPhams.Remove(this);
					}
					this._tb_DonHang.Entity = value;
					if ((value != null))
					{
						value.tb_DonHang_SanPhams.Add(this);
						this._idDonHang = value.idDonHang;
					}
					else
					{
						this._idDonHang = default(int);
					}
					this.SendPropertyChanged("tb_DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_SanPham_tb_DonHang_SanPham", Storage="_tb_SanPham", ThisKey="idSP", OtherKey="idSP", IsForeignKey=true)]
		public tb_SanPham tb_SanPham
		{
			get
			{
				return this._tb_SanPham.Entity;
			}
			set
			{
				tb_SanPham previousValue = this._tb_SanPham.Entity;
				if (((previousValue != value) 
							|| (this._tb_SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tb_SanPham.Entity = null;
						previousValue.tb_DonHang_SanPhams.Remove(this);
					}
					this._tb_SanPham.Entity = value;
					if ((value != null))
					{
						value.tb_DonHang_SanPhams.Add(this);
						this._idSP = value.idSP;
					}
					else
					{
						this._idSP = default(int);
					}
					this.SendPropertyChanged("tb_SanPham");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_HangSanPham")]
	public partial class tb_HangSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idHang;
		
		private string _tenHang;
		
		private string _logo;
		
		private string _linhVuc;
		
		private string _quocGia;
		
		private int _namThanhLap;
		
		private EntitySet<tb_LoaiSanPham> _tb_LoaiSanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidHangChanging(int value);
    partial void OnidHangChanged();
    partial void OntenHangChanging(string value);
    partial void OntenHangChanged();
    partial void OnlogoChanging(string value);
    partial void OnlogoChanged();
    partial void OnlinhVucChanging(string value);
    partial void OnlinhVucChanged();
    partial void OnquocGiaChanging(string value);
    partial void OnquocGiaChanged();
    partial void OnnamThanhLapChanging(int value);
    partial void OnnamThanhLapChanged();
    #endregion
		
		public tb_HangSanPham()
		{
			this._tb_LoaiSanPhams = new EntitySet<tb_LoaiSanPham>(new Action<tb_LoaiSanPham>(this.attach_tb_LoaiSanPhams), new Action<tb_LoaiSanPham>(this.detach_tb_LoaiSanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idHang
		{
			get
			{
				return this._idHang;
			}
			set
			{
				if ((this._idHang != value))
				{
					this.OnidHangChanging(value);
					this.SendPropertyChanging();
					this._idHang = value;
					this.SendPropertyChanged("idHang");
					this.OnidHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tenHang
		{
			get
			{
				return this._tenHang;
			}
			set
			{
				if ((this._tenHang != value))
				{
					this.OntenHangChanging(value);
					this.SendPropertyChanging();
					this._tenHang = value;
					this.SendPropertyChanged("tenHang");
					this.OntenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logo", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string logo
		{
			get
			{
				return this._logo;
			}
			set
			{
				if ((this._logo != value))
				{
					this.OnlogoChanging(value);
					this.SendPropertyChanging();
					this._logo = value;
					this.SendPropertyChanged("logo");
					this.OnlogoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_linhVuc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string linhVuc
		{
			get
			{
				return this._linhVuc;
			}
			set
			{
				if ((this._linhVuc != value))
				{
					this.OnlinhVucChanging(value);
					this.SendPropertyChanging();
					this._linhVuc = value;
					this.SendPropertyChanged("linhVuc");
					this.OnlinhVucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quocGia", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string quocGia
		{
			get
			{
				return this._quocGia;
			}
			set
			{
				if ((this._quocGia != value))
				{
					this.OnquocGiaChanging(value);
					this.SendPropertyChanging();
					this._quocGia = value;
					this.SendPropertyChanged("quocGia");
					this.OnquocGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namThanhLap", DbType="Int NOT NULL")]
		public int namThanhLap
		{
			get
			{
				return this._namThanhLap;
			}
			set
			{
				if ((this._namThanhLap != value))
				{
					this.OnnamThanhLapChanging(value);
					this.SendPropertyChanging();
					this._namThanhLap = value;
					this.SendPropertyChanged("namThanhLap");
					this.OnnamThanhLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_HangSanPham_tb_LoaiSanPham", Storage="_tb_LoaiSanPhams", ThisKey="idHang", OtherKey="idHang")]
		public EntitySet<tb_LoaiSanPham> tb_LoaiSanPhams
		{
			get
			{
				return this._tb_LoaiSanPhams;
			}
			set
			{
				this._tb_LoaiSanPhams.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tb_LoaiSanPhams(tb_LoaiSanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_HangSanPham = this;
		}
		
		private void detach_tb_LoaiSanPhams(tb_LoaiSanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_HangSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_LoaiSanPham")]
	public partial class tb_LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idLoaiSP;
		
		private int _idHang;
		
		private string _tenLoaiSP;
		
		private bool _trangThai;
		
		private EntitySet<tb_SanPham> _tb_SanPhams;
		
		private EntityRef<tb_HangSanPham> _tb_HangSanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLoaiSPChanging(int value);
    partial void OnidLoaiSPChanged();
    partial void OnidHangChanging(int value);
    partial void OnidHangChanged();
    partial void OntenLoaiSPChanging(string value);
    partial void OntenLoaiSPChanged();
    partial void OntrangThaiChanging(bool value);
    partial void OntrangThaiChanged();
    #endregion
		
		public tb_LoaiSanPham()
		{
			this._tb_SanPhams = new EntitySet<tb_SanPham>(new Action<tb_SanPham>(this.attach_tb_SanPhams), new Action<tb_SanPham>(this.detach_tb_SanPhams));
			this._tb_HangSanPham = default(EntityRef<tb_HangSanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLoaiSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idLoaiSP
		{
			get
			{
				return this._idLoaiSP;
			}
			set
			{
				if ((this._idLoaiSP != value))
				{
					this.OnidLoaiSPChanging(value);
					this.SendPropertyChanging();
					this._idLoaiSP = value;
					this.SendPropertyChanged("idLoaiSP");
					this.OnidLoaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idHang", DbType="Int NOT NULL")]
		public int idHang
		{
			get
			{
				return this._idHang;
			}
			set
			{
				if ((this._idHang != value))
				{
					if (this._tb_HangSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidHangChanging(value);
					this.SendPropertyChanging();
					this._idHang = value;
					this.SendPropertyChanged("idHang");
					this.OnidHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenLoaiSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenLoaiSP
		{
			get
			{
				return this._tenLoaiSP;
			}
			set
			{
				if ((this._tenLoaiSP != value))
				{
					this.OntenLoaiSPChanging(value);
					this.SendPropertyChanging();
					this._tenLoaiSP = value;
					this.SendPropertyChanged("tenLoaiSP");
					this.OntenLoaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trangThai", DbType="Bit NOT NULL")]
		public bool trangThai
		{
			get
			{
				return this._trangThai;
			}
			set
			{
				if ((this._trangThai != value))
				{
					this.OntrangThaiChanging(value);
					this.SendPropertyChanging();
					this._trangThai = value;
					this.SendPropertyChanged("trangThai");
					this.OntrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_LoaiSanPham_tb_SanPham", Storage="_tb_SanPhams", ThisKey="idLoaiSP", OtherKey="idLoaiSP")]
		public EntitySet<tb_SanPham> tb_SanPhams
		{
			get
			{
				return this._tb_SanPhams;
			}
			set
			{
				this._tb_SanPhams.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_HangSanPham_tb_LoaiSanPham", Storage="_tb_HangSanPham", ThisKey="idHang", OtherKey="idHang", IsForeignKey=true)]
		public tb_HangSanPham tb_HangSanPham
		{
			get
			{
				return this._tb_HangSanPham.Entity;
			}
			set
			{
				tb_HangSanPham previousValue = this._tb_HangSanPham.Entity;
				if (((previousValue != value) 
							|| (this._tb_HangSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tb_HangSanPham.Entity = null;
						previousValue.tb_LoaiSanPhams.Remove(this);
					}
					this._tb_HangSanPham.Entity = value;
					if ((value != null))
					{
						value.tb_LoaiSanPhams.Add(this);
						this._idHang = value.idHang;
					}
					else
					{
						this._idHang = default(int);
					}
					this.SendPropertyChanged("tb_HangSanPham");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tb_SanPhams(tb_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_LoaiSanPham = this;
		}
		
		private void detach_tb_SanPhams(tb_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_LoaiSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_SanPham")]
	public partial class tb_SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idSP;
		
		private int _idLoaiSP;
		
		private string _tenSP;
		
		private bool _trangThai;
		
		private decimal _giaBan;
		
		private string _moTa;
		
		private string _hinh;
		
		private int _soLuongTon;
		
		private System.DateTime _ngayCapNhat;
		
		private EntitySet<tb_DonHang_SanPham> _tb_DonHang_SanPhams;
		
		private EntityRef<tb_LoaiSanPham> _tb_LoaiSanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidSPChanging(int value);
    partial void OnidSPChanged();
    partial void OnidLoaiSPChanging(int value);
    partial void OnidLoaiSPChanged();
    partial void OntenSPChanging(string value);
    partial void OntenSPChanged();
    partial void OntrangThaiChanging(bool value);
    partial void OntrangThaiChanged();
    partial void OngiaBanChanging(decimal value);
    partial void OngiaBanChanged();
    partial void OnmoTaChanging(string value);
    partial void OnmoTaChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OnsoLuongTonChanging(int value);
    partial void OnsoLuongTonChanged();
    partial void OnngayCapNhatChanging(System.DateTime value);
    partial void OnngayCapNhatChanged();
    #endregion
		
		public tb_SanPham()
		{
			this._tb_DonHang_SanPhams = new EntitySet<tb_DonHang_SanPham>(new Action<tb_DonHang_SanPham>(this.attach_tb_DonHang_SanPhams), new Action<tb_DonHang_SanPham>(this.detach_tb_DonHang_SanPhams));
			this._tb_LoaiSanPham = default(EntityRef<tb_LoaiSanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idSP
		{
			get
			{
				return this._idSP;
			}
			set
			{
				if ((this._idSP != value))
				{
					this.OnidSPChanging(value);
					this.SendPropertyChanging();
					this._idSP = value;
					this.SendPropertyChanged("idSP");
					this.OnidSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLoaiSP", DbType="Int NOT NULL")]
		public int idLoaiSP
		{
			get
			{
				return this._idLoaiSP;
			}
			set
			{
				if ((this._idLoaiSP != value))
				{
					if (this._tb_LoaiSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidLoaiSPChanging(value);
					this.SendPropertyChanging();
					this._idLoaiSP = value;
					this.SendPropertyChanged("idLoaiSP");
					this.OnidLoaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenSP
		{
			get
			{
				return this._tenSP;
			}
			set
			{
				if ((this._tenSP != value))
				{
					this.OntenSPChanging(value);
					this.SendPropertyChanging();
					this._tenSP = value;
					this.SendPropertyChanged("tenSP");
					this.OntenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trangThai", DbType="Bit NOT NULL")]
		public bool trangThai
		{
			get
			{
				return this._trangThai;
			}
			set
			{
				if ((this._trangThai != value))
				{
					this.OntrangThaiChanging(value);
					this.SendPropertyChanging();
					this._trangThai = value;
					this.SendPropertyChanged("trangThai");
					this.OntrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaBan", DbType="Decimal(18,0) NOT NULL")]

		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public decimal giaBan
		{
			get
			{
				return this._giaBan;
			}
			set
			{
				if ((this._giaBan != value))
				{
					this.OngiaBanChanging(value);
					this.SendPropertyChanging();
					this._giaBan = value;
					this.SendPropertyChanged("giaBan");
					this.OngiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_moTa", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string moTa
		{
			get
			{
				return this._moTa;
			}
			set
			{
				if ((this._moTa != value))
				{
					this.OnmoTaChanging(value);
					this.SendPropertyChanging();
					this._moTa = value;
					this.SendPropertyChanged("moTa");
					this.OnmoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soLuongTon", DbType="Int NOT NULL")]
		public int soLuongTon
		{
			get
			{
				return this._soLuongTon;
			}
			set
			{
				if ((this._soLuongTon != value))
				{
					this.OnsoLuongTonChanging(value);
					this.SendPropertyChanging();
					this._soLuongTon = value;
					this.SendPropertyChanged("soLuongTon");
					this.OnsoLuongTonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayCapNhat", DbType="DateTime NOT NULL")]
		[DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
		public System.DateTime ngayCapNhat
		{
			get
			{
				return this._ngayCapNhat;
			}
			set
			{
				if ((this._ngayCapNhat != value))
				{
					this.OnngayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._ngayCapNhat = value;
					this.SendPropertyChanged("ngayCapNhat");
					this.OnngayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_SanPham_tb_DonHang_SanPham", Storage="_tb_DonHang_SanPhams", ThisKey="idSP", OtherKey="idSP")]
		public EntitySet<tb_DonHang_SanPham> tb_DonHang_SanPhams
		{
			get
			{
				return this._tb_DonHang_SanPhams;
			}
			set
			{
				this._tb_DonHang_SanPhams.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_LoaiSanPham_tb_SanPham", Storage="_tb_LoaiSanPham", ThisKey="idLoaiSP", OtherKey="idLoaiSP", IsForeignKey=true)]
		public tb_LoaiSanPham tb_LoaiSanPham
		{
			get
			{
				return this._tb_LoaiSanPham.Entity;
			}
			set
			{
				tb_LoaiSanPham previousValue = this._tb_LoaiSanPham.Entity;
				if (((previousValue != value) 
							|| (this._tb_LoaiSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tb_LoaiSanPham.Entity = null;
						previousValue.tb_SanPhams.Remove(this);
					}
					this._tb_LoaiSanPham.Entity = value;
					if ((value != null))
					{
						value.tb_SanPhams.Add(this);
						this._idLoaiSP = value.idLoaiSP;
					}
					else
					{
						this._idLoaiSP = default(int);
					}
					this.SendPropertyChanged("tb_LoaiSanPham");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tb_DonHang_SanPhams(tb_DonHang_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_SanPham = this;
		}
		
		private void detach_tb_DonHang_SanPhams(tb_DonHang_SanPham entity)
		{
			this.SendPropertyChanging();
			entity.tb_SanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_TaiKhoan")]
	public partial class tb_TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idTaiKhoan;
		
		private string _tenDangNhap;
		
		private string _matKhau;
		
		private string _hoTen;
		
		private string _soDienThoai;
		
		private string _diaChi;
		
		private string _eMail;
		
		private bool _laAdmin;
		
		private EntitySet<tb_DonHang> _tb_DonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTaiKhoanChanging(int value);
    partial void OnidTaiKhoanChanged();
    partial void OntenDangNhapChanging(string value);
    partial void OntenDangNhapChanged();
    partial void OnmatKhauChanging(string value);
    partial void OnmatKhauChanged();
    partial void OnhoTenChanging(string value);
    partial void OnhoTenChanged();
    partial void OnsoDienThoaiChanging(string value);
    partial void OnsoDienThoaiChanged();
    partial void OndiaChiChanging(string value);
    partial void OndiaChiChanged();
    partial void OneMailChanging(string value);
    partial void OneMailChanged();
    partial void OnlaAdminChanging(bool value);
    partial void OnlaAdminChanged();
    #endregion
		
		public tb_TaiKhoan()
		{
			this._tb_DonHangs = new EntitySet<tb_DonHang>(new Action<tb_DonHang>(this.attach_tb_DonHangs), new Action<tb_DonHang>(this.detach_tb_DonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTaiKhoan", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idTaiKhoan
		{
			get
			{
				return this._idTaiKhoan;
			}
			set
			{
				if ((this._idTaiKhoan != value))
				{
					this.OnidTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._idTaiKhoan = value;
					this.SendPropertyChanged("idTaiKhoan");
					this.OnidTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenDangNhap", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string tenDangNhap
		{
			get
			{
				return this._tenDangNhap;
			}
			set
			{
				if ((this._tenDangNhap != value))
				{
					this.OntenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._tenDangNhap = value;
					this.SendPropertyChanged("tenDangNhap");
					this.OntenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matKhau", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string matKhau
		{
			get
			{
				return this._matKhau;
			}
			set
			{
				if ((this._matKhau != value))
				{
					this.OnmatKhauChanging(value);
					this.SendPropertyChanging();
					this._matKhau = value;
					this.SendPropertyChanged("matKhau");
					this.OnmatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string hoTen
		{
			get
			{
				return this._hoTen;
			}
			set
			{
				if ((this._hoTen != value))
				{
					this.OnhoTenChanging(value);
					this.SendPropertyChanging();
					this._hoTen = value;
					this.SendPropertyChanged("hoTen");
					this.OnhoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soDienThoai", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string soDienThoai
		{
			get
			{
				return this._soDienThoai;
			}
			set
			{
				if ((this._soDienThoai != value))
				{
					this.OnsoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._soDienThoai = value;
					this.SendPropertyChanged("soDienThoai");
					this.OnsoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string diaChi
		{
			get
			{
				return this._diaChi;
			}
			set
			{
				if ((this._diaChi != value))
				{
					this.OndiaChiChanging(value);
					this.SendPropertyChanging();
					this._diaChi = value;
					this.SendPropertyChanged("diaChi");
					this.OndiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eMail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string eMail
		{
			get
			{
				return this._eMail;
			}
			set
			{
				if ((this._eMail != value))
				{
					this.OneMailChanging(value);
					this.SendPropertyChanging();
					this._eMail = value;
					this.SendPropertyChanged("eMail");
					this.OneMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_laAdmin", DbType="Bit NOT NULL")]
		public bool laAdmin
		{
			get
			{
				return this._laAdmin;
			}
			set
			{
				if ((this._laAdmin != value))
				{
					this.OnlaAdminChanging(value);
					this.SendPropertyChanging();
					this._laAdmin = value;
					this.SendPropertyChanged("laAdmin");
					this.OnlaAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_TaiKhoan_tb_DonHang", Storage="_tb_DonHangs", ThisKey="idTaiKhoan", OtherKey="idTaiKhoan")]
		public EntitySet<tb_DonHang> tb_DonHangs
		{
			get
			{
				return this._tb_DonHangs;
			}
			set
			{
				this._tb_DonHangs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tb_DonHangs(tb_DonHang entity)
		{
			this.SendPropertyChanging();
			entity.tb_TaiKhoan = this;
		}
		
		private void detach_tb_DonHangs(tb_DonHang entity)
		{
			this.SendPropertyChanging();
			entity.tb_TaiKhoan = null;
		}
	}
}
#pragma warning restore 1591
