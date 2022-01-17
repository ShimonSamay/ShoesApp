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

namespace SneakersShops.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShoesShopSB")]
	public partial class KidsDBContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKidsShoe(KidsShoe instance);
    partial void UpdateKidsShoe(KidsShoe instance);
    partial void DeleteKidsShoe(KidsShoe instance);
    #endregion
		
		public KidsDBContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShoesShopSBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KidsDBContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidsDBContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidsDBContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KidsDBContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KidsShoe> KidsShoes
		{
			get
			{
				return this.GetTable<KidsShoe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KidsShoes")]
	public partial class KidsShoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Company;
		
		private string _Material;
		
		private System.Nullable<bool> _AtStock;
		
		private System.Nullable<int> _Size;
		
		private System.Nullable<int> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnMaterialChanging(string value);
    partial void OnMaterialChanged();
    partial void OnAtStockChanging(System.Nullable<bool> value);
    partial void OnAtStockChanged();
    partial void OnSizeChanging(System.Nullable<int> value);
    partial void OnSizeChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    #endregion
		
		public KidsShoe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(50)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Material", DbType="NVarChar(50)")]
		public string Material
		{
			get
			{
				return this._Material;
			}
			set
			{
				if ((this._Material != value))
				{
					this.OnMaterialChanging(value);
					this.SendPropertyChanging();
					this._Material = value;
					this.SendPropertyChanged("Material");
					this.OnMaterialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtStock", DbType="Bit")]
		public System.Nullable<bool> AtStock
		{
			get
			{
				return this._AtStock;
			}
			set
			{
				if ((this._AtStock != value))
				{
					this.OnAtStockChanging(value);
					this.SendPropertyChanging();
					this._AtStock = value;
					this.SendPropertyChanged("AtStock");
					this.OnAtStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int")]
		public System.Nullable<int> Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
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
