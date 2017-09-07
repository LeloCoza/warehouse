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

namespace WareHouseSchool_Service
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WareHouseStore")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBackEndStatus(BackEndStatus instance);
    partial void UpdateBackEndStatus(BackEndStatus instance);
    partial void DeleteBackEndStatus(BackEndStatus instance);
    partial void InsertClientStatuse(ClientStatuse instance);
    partial void UpdateClientStatuse(ClientStatuse instance);
    partial void DeleteClientStatuse(ClientStatuse instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProductCard(ProductCard instance);
    partial void UpdateProductCard(ProductCard instance);
    partial void DeleteProductCard(ProductCard instance);
    partial void InsertProductType(ProductType instance);
    partial void UpdateProductType(ProductType instance);
    partial void DeleteProductType(ProductType instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WareHouseStoreConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BackEndStatus> BackEndStatus
		{
			get
			{
				return this.GetTable<BackEndStatus>();
			}
		}
		
		public System.Data.Linq.Table<ClientStatuse> ClientStatuses
		{
			get
			{
				return this.GetTable<ClientStatuse>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductCard> ProductCards
		{
			get
			{
				return this.GetTable<ProductCard>();
			}
		}
		
		public System.Data.Linq.Table<ProductType> ProductTypes
		{
			get
			{
				return this.GetTable<ProductType>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BackEndStatus")]
	public partial class BackEndStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BackEndStatusId;
		
		private string _BackEndStatusName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBackEndStatusIdChanging(int value);
    partial void OnBackEndStatusIdChanged();
    partial void OnBackEndStatusNameChanging(string value);
    partial void OnBackEndStatusNameChanged();
    #endregion
		
		public BackEndStatus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BackEndStatusId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BackEndStatusId
		{
			get
			{
				return this._BackEndStatusId;
			}
			set
			{
				if ((this._BackEndStatusId != value))
				{
					this.OnBackEndStatusIdChanging(value);
					this.SendPropertyChanging();
					this._BackEndStatusId = value;
					this.SendPropertyChanged("BackEndStatusId");
					this.OnBackEndStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BackEndStatusName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string BackEndStatusName
		{
			get
			{
				return this._BackEndStatusName;
			}
			set
			{
				if ((this._BackEndStatusName != value))
				{
					this.OnBackEndStatusNameChanging(value);
					this.SendPropertyChanging();
					this._BackEndStatusName = value;
					this.SendPropertyChanged("BackEndStatusName");
					this.OnBackEndStatusNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClientStatuses")]
	public partial class ClientStatuse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClientStatusId;
		
		private string _ClientStatusName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientStatusIdChanging(int value);
    partial void OnClientStatusIdChanged();
    partial void OnClientStatusNameChanging(string value);
    partial void OnClientStatusNameChanged();
    #endregion
		
		public ClientStatuse()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientStatusId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ClientStatusId
		{
			get
			{
				return this._ClientStatusId;
			}
			set
			{
				if ((this._ClientStatusId != value))
				{
					this.OnClientStatusIdChanging(value);
					this.SendPropertyChanging();
					this._ClientStatusId = value;
					this.SendPropertyChanged("ClientStatusId");
					this.OnClientStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientStatusName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ClientStatusName
		{
			get
			{
				return this._ClientStatusName;
			}
			set
			{
				if ((this._ClientStatusName != value))
				{
					this.OnClientStatusNameChanging(value);
					this.SendPropertyChanging();
					this._ClientStatusName = value;
					this.SendPropertyChanged("ClientStatusName");
					this.OnClientStatusNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderId;
		
		private int _ProductID;
		
		private System.Nullable<int> _CardID;
		
		private decimal _OrderPrice;
		
		private System.DateTime _OrderDate;
		
		private int _ClientStatusId;
		
		private int _BackEndStatusId;
		
		private System.Nullable<int> _UserId;
		
		private System.Nullable<int> _ProductTypeId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnCardIDChanging(System.Nullable<int> value);
    partial void OnCardIDChanged();
    partial void OnOrderPriceChanging(decimal value);
    partial void OnOrderPriceChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    partial void OnClientStatusIdChanging(int value);
    partial void OnClientStatusIdChanged();
    partial void OnBackEndStatusIdChanging(int value);
    partial void OnBackEndStatusIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnProductTypeIdChanging(System.Nullable<int> value);
    partial void OnProductTypeIdChanged();
    #endregion
		
		public Order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardID", DbType="Int")]
		public System.Nullable<int> CardID
		{
			get
			{
				return this._CardID;
			}
			set
			{
				if ((this._CardID != value))
				{
					this.OnCardIDChanging(value);
					this.SendPropertyChanging();
					this._CardID = value;
					this.SendPropertyChanged("CardID");
					this.OnCardIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderPrice", DbType="Money NOT NULL")]
		public decimal OrderPrice
		{
			get
			{
				return this._OrderPrice;
			}
			set
			{
				if ((this._OrderPrice != value))
				{
					this.OnOrderPriceChanging(value);
					this.SendPropertyChanging();
					this._OrderPrice = value;
					this.SendPropertyChanged("OrderPrice");
					this.OnOrderPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime NOT NULL")]
		public System.DateTime OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientStatusId", DbType="Int NOT NULL")]
		public int ClientStatusId
		{
			get
			{
				return this._ClientStatusId;
			}
			set
			{
				if ((this._ClientStatusId != value))
				{
					this.OnClientStatusIdChanging(value);
					this.SendPropertyChanging();
					this._ClientStatusId = value;
					this.SendPropertyChanged("ClientStatusId");
					this.OnClientStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BackEndStatusId", DbType="Int NOT NULL")]
		public int BackEndStatusId
		{
			get
			{
				return this._BackEndStatusId;
			}
			set
			{
				if ((this._BackEndStatusId != value))
				{
					this.OnBackEndStatusIdChanging(value);
					this.SendPropertyChanging();
					this._BackEndStatusId = value;
					this.SendPropertyChanged("BackEndStatusId");
					this.OnBackEndStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductTypeId", DbType="Int")]
		public System.Nullable<int> ProductTypeId
		{
			get
			{
				return this._ProductTypeId;
			}
			set
			{
				if ((this._ProductTypeId != value))
				{
					this.OnProductTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ProductTypeId = value;
					this.SendPropertyChanged("ProductTypeId");
					this.OnProductTypeIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private int _ProductTypeId;
		
		private System.Nullable<System.DateTime> _Date;
		
		private string _Description;
		
		private decimal _Price;
		
		private int _Quantity;
		
		private string _Image64String;
		
		private string _isRemoved;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductTypeIdChanging(int value);
    partial void OnProductTypeIdChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnImage64StringChanging(string value);
    partial void OnImage64StringChanged();
    partial void OnisRemovedChanging(string value);
    partial void OnisRemovedChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductTypeId", DbType="Int NOT NULL")]
		public int ProductTypeId
		{
			get
			{
				return this._ProductTypeId;
			}
			set
			{
				if ((this._ProductTypeId != value))
				{
					this.OnProductTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ProductTypeId = value;
					this.SendPropertyChanged("ProductTypeId");
					this.OnProductTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image64String", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Image64String
		{
			get
			{
				return this._Image64String;
			}
			set
			{
				if ((this._Image64String != value))
				{
					this.OnImage64StringChanging(value);
					this.SendPropertyChanging();
					this._Image64String = value;
					this.SendPropertyChanged("Image64String");
					this.OnImage64StringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isRemoved", DbType="VarChar(5)")]
		public string isRemoved
		{
			get
			{
				return this._isRemoved;
			}
			set
			{
				if ((this._isRemoved != value))
				{
					this.OnisRemovedChanging(value);
					this.SendPropertyChanging();
					this._isRemoved = value;
					this.SendPropertyChanged("isRemoved");
					this.OnisRemovedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductCard")]
	public partial class ProductCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CardId;
		
		private int _ProductId;
		
		private int _ProductTypeId;
		
		private System.DateTime _DateTime;
		
		private int _UserId;
		
		private System.Nullable<int> _Quantity;
		
		private string _isRemoved;
		
		private System.Nullable<System.DateTime> _isRemovedDate;
		
		private System.Nullable<decimal> _productPrice;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCardIdChanging(int value);
    partial void OnCardIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductTypeIdChanging(int value);
    partial void OnProductTypeIdChanged();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnisRemovedChanging(string value);
    partial void OnisRemovedChanged();
    partial void OnisRemovedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnisRemovedDateChanged();
    partial void OnproductPriceChanging(System.Nullable<decimal> value);
    partial void OnproductPriceChanged();
    #endregion
		
		public ProductCard()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CardId
		{
			get
			{
				return this._CardId;
			}
			set
			{
				if ((this._CardId != value))
				{
					this.OnCardIdChanging(value);
					this.SendPropertyChanging();
					this._CardId = value;
					this.SendPropertyChanged("CardId");
					this.OnCardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductTypeId", DbType="Int NOT NULL")]
		public int ProductTypeId
		{
			get
			{
				return this._ProductTypeId;
			}
			set
			{
				if ((this._ProductTypeId != value))
				{
					this.OnProductTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ProductTypeId = value;
					this.SendPropertyChanged("ProductTypeId");
					this.OnProductTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isRemoved", DbType="VarChar(5)")]
		public string isRemoved
		{
			get
			{
				return this._isRemoved;
			}
			set
			{
				if ((this._isRemoved != value))
				{
					this.OnisRemovedChanging(value);
					this.SendPropertyChanging();
					this._isRemoved = value;
					this.SendPropertyChanged("isRemoved");
					this.OnisRemovedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isRemovedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> isRemovedDate
		{
			get
			{
				return this._isRemovedDate;
			}
			set
			{
				if ((this._isRemovedDate != value))
				{
					this.OnisRemovedDateChanging(value);
					this.SendPropertyChanging();
					this._isRemovedDate = value;
					this.SendPropertyChanged("isRemovedDate");
					this.OnisRemovedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productPrice", DbType="Money")]
		public System.Nullable<decimal> productPrice
		{
			get
			{
				return this._productPrice;
			}
			set
			{
				if ((this._productPrice != value))
				{
					this.OnproductPriceChanging(value);
					this.SendPropertyChanging();
					this._productPrice = value;
					this.SendPropertyChanged("productPrice");
					this.OnproductPriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductType")]
	public partial class ProductType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _productTypeId;
		
		private string _productCategory;
		
		private string _productTypeName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductTypeIdChanging(int value);
    partial void OnproductTypeIdChanged();
    partial void OnproductCategoryChanging(string value);
    partial void OnproductCategoryChanged();
    partial void OnproductTypeNameChanging(string value);
    partial void OnproductTypeNameChanged();
    #endregion
		
		public ProductType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productTypeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int productTypeId
		{
			get
			{
				return this._productTypeId;
			}
			set
			{
				if ((this._productTypeId != value))
				{
					this.OnproductTypeIdChanging(value);
					this.SendPropertyChanging();
					this._productTypeId = value;
					this.SendPropertyChanged("productTypeId");
					this.OnproductTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productCategory", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string productCategory
		{
			get
			{
				return this._productCategory;
			}
			set
			{
				if ((this._productCategory != value))
				{
					this.OnproductCategoryChanging(value);
					this.SendPropertyChanging();
					this._productCategory = value;
					this.SendPropertyChanged("productCategory");
					this.OnproductCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productTypeName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string productTypeName
		{
			get
			{
				return this._productTypeName;
			}
			set
			{
				if ((this._productTypeName != value))
				{
					this.OnproductTypeNameChanging(value);
					this.SendPropertyChanging();
					this._productTypeName = value;
					this.SendPropertyChanged("productTypeName");
					this.OnproductTypeNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userId;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _emailAdress;
		
		private string _Adress;
		
		private string _contactNumber;
		
		private string _authenticationLevel;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnemailAdressChanging(string value);
    partial void OnemailAdressChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OncontactNumberChanging(string value);
    partial void OncontactNumberChanged();
    partial void OnauthenticationLevelChanging(string value);
    partial void OnauthenticationLevelChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAdress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string emailAdress
		{
			get
			{
				return this._emailAdress;
			}
			set
			{
				if ((this._emailAdress != value))
				{
					this.OnemailAdressChanging(value);
					this.SendPropertyChanging();
					this._emailAdress = value;
					this.SendPropertyChanged("emailAdress");
					this.OnemailAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactNumber", DbType="VarChar(50)")]
		public string contactNumber
		{
			get
			{
				return this._contactNumber;
			}
			set
			{
				if ((this._contactNumber != value))
				{
					this.OncontactNumberChanging(value);
					this.SendPropertyChanging();
					this._contactNumber = value;
					this.SendPropertyChanged("contactNumber");
					this.OncontactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authenticationLevel", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string authenticationLevel
		{
			get
			{
				return this._authenticationLevel;
			}
			set
			{
				if ((this._authenticationLevel != value))
				{
					this.OnauthenticationLevelChanging(value);
					this.SendPropertyChanging();
					this._authenticationLevel = value;
					this.SendPropertyChanged("authenticationLevel");
					this.OnauthenticationLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
}
#pragma warning restore 1591
