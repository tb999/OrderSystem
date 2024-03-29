﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderSystem.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OrderSystem")]
	public partial class ProductsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public ProductsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OrderSystemConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private short _CategoryID;
		
		private string _ProductName;
		
		private string _ProductDescription;
		
		private short _ProductQuantity;
		
		private decimal _ProductPrice;
		
		private System.Data.Linq.Binary _ProductImage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnCategoryIDChanging(short value);
    partial void OnCategoryIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductDescriptionChanging(string value);
    partial void OnProductDescriptionChanged();
    partial void OnProductQuantityChanging(short value);
    partial void OnProductQuantityChanged();
    partial void OnProductPriceChanging(decimal value);
    partial void OnProductPriceChanged();
    partial void OnProductImageChanging(System.Data.Linq.Binary value);
    partial void OnProductImageChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="SmallInt NOT NULL")]
		public short CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(70) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescription", DbType="VarChar(150)")]
		public string ProductDescription
		{
			get
			{
				return this._ProductDescription;
			}
			set
			{
				if ((this._ProductDescription != value))
				{
					this.OnProductDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ProductDescription = value;
					this.SendPropertyChanged("ProductDescription");
					this.OnProductDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductQuantity", DbType="SmallInt NOT NULL")]
		public short ProductQuantity
		{
			get
			{
				return this._ProductQuantity;
			}
			set
			{
				if ((this._ProductQuantity != value))
				{
					this.OnProductQuantityChanging(value);
					this.SendPropertyChanging();
					this._ProductQuantity = value;
					this.SendPropertyChanged("ProductQuantity");
					this.OnProductQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Money NOT NULL")]
		public decimal ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this.OnProductPriceChanging(value);
					this.SendPropertyChanging();
					this._ProductPrice = value;
					this.SendPropertyChanged("ProductPrice");
					this.OnProductPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductImage", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ProductImage
		{
			get
			{
				return this._ProductImage;
			}
			set
			{
				if ((this._ProductImage != value))
				{
					this.OnProductImageChanging(value);
					this.SendPropertyChanging();
					this._ProductImage = value;
					this.SendPropertyChanged("ProductImage");
					this.OnProductImageChanged();
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
