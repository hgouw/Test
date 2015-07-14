﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQtoSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ASX.Test")]
	public partial class ASXDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCompany(Company instance);
    partial void UpdateCompany(Company instance);
    partial void DeleteCompany(Company instance);
    partial void InsertEndOfDay(EndOfDay instance);
    partial void UpdateEndOfDay(EndOfDay instance);
    partial void DeleteEndOfDay(EndOfDay instance);
    partial void InsertIndustryGroup(IndustryGroup instance);
    partial void UpdateIndustryGroup(IndustryGroup instance);
    partial void DeleteIndustryGroup(IndustryGroup instance);
    partial void InsertWatchList(WatchList instance);
    partial void UpdateWatchList(WatchList instance);
    partial void DeleteWatchList(WatchList instance);
    #endregion
		
		public ASXDataContext() : 
				base(global::LINQtoSQL.Properties.Settings.Default.ASX_TestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ASXDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ASXDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ASXDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ASXDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Company> Companies
		{
			get
			{
				return this.GetTable<Company>();
			}
		}
		
		public System.Data.Linq.Table<EndOfDay> EndOfDays
		{
			get
			{
				return this.GetTable<EndOfDay>();
			}
		}
		
		public System.Data.Linq.Table<IndustryGroup> IndustryGroups
		{
			get
			{
				return this.GetTable<IndustryGroup>();
			}
		}
		
		public System.Data.Linq.Table<WatchList> WatchLists
		{
			get
			{
				return this.GetTable<WatchList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Companies")]
	public partial class Company : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private string _Name;
		
		private string _Group;
		
		private EntitySet<EndOfDay> _EndOfDays;
		
		private EntityRef<WatchList> _WatchList;
		
		private EntityRef<IndustryGroup> _IndustryGroup;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGroupChanging(string value);
    partial void OnGroupChanged();
    #endregion
		
		public Company()
		{
			this._EndOfDays = new EntitySet<EndOfDay>(new Action<EndOfDay>(this.attach_EndOfDays), new Action<EndOfDay>(this.detach_EndOfDays));
			this._WatchList = default(EntityRef<WatchList>);
			this._IndustryGroup = default(EntityRef<IndustryGroup>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Group]", Storage="_Group", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				if ((this._Group != value))
				{
					this.OnGroupChanging(value);
					this.SendPropertyChanging();
					this._Group = value;
					this.SendPropertyChanged("Group");
					this.OnGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_EndOfDay", Storage="_EndOfDays", ThisKey="Code", OtherKey="Code")]
		public EntitySet<EndOfDay> EndOfDays
		{
			get
			{
				return this._EndOfDays;
			}
			set
			{
				this._EndOfDays.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_WatchList", Storage="_WatchList", ThisKey="Code", OtherKey="Code", IsUnique=true, IsForeignKey=false)]
		public WatchList WatchList
		{
			get
			{
				return this._WatchList.Entity;
			}
			set
			{
				WatchList previousValue = this._WatchList.Entity;
				if (((previousValue != value) 
							|| (this._WatchList.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._WatchList.Entity = null;
						previousValue.Company = null;
					}
					this._WatchList.Entity = value;
					if ((value != null))
					{
						value.Company = this;
					}
					this.SendPropertyChanged("WatchList");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IndustryGroup_Company", Storage="_IndustryGroup", ThisKey="Group", OtherKey="Group", IsForeignKey=true)]
		public IndustryGroup IndustryGroup
		{
			get
			{
				return this._IndustryGroup.Entity;
			}
			set
			{
				IndustryGroup previousValue = this._IndustryGroup.Entity;
				if (((previousValue != value) 
							|| (this._IndustryGroup.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IndustryGroup.Entity = null;
						previousValue.Companies.Remove(this);
					}
					this._IndustryGroup.Entity = value;
					if ((value != null))
					{
						value.Companies.Add(this);
						this._Group = value.Group;
					}
					else
					{
						this._Group = default(string);
					}
					this.SendPropertyChanged("IndustryGroup");
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
		
		private void attach_EndOfDays(EndOfDay entity)
		{
			this.SendPropertyChanging();
			entity.Company = this;
		}
		
		private void detach_EndOfDays(EndOfDay entity)
		{
			this.SendPropertyChanging();
			entity.Company = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EndOfDays")]
	public partial class EndOfDay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private System.DateTime _Date;
		
		private decimal _Open;
		
		private decimal _High;
		
		private decimal _Low;
		
		private decimal _Last;
		
		private int _Volume;
		
		private EntityRef<Company> _Company;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnOpenChanging(decimal value);
    partial void OnOpenChanged();
    partial void OnHighChanging(decimal value);
    partial void OnHighChanged();
    partial void OnLowChanging(decimal value);
    partial void OnLowChanged();
    partial void OnLastChanging(decimal value);
    partial void OnLastChanged();
    partial void OnVolumeChanging(int value);
    partial void OnVolumeChanged();
    #endregion
		
		public EndOfDay()
		{
			this._Company = default(EntityRef<Company>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					if (this._Company.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime Date
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Open]", Storage="_Open", DbType="Decimal(6,3) NOT NULL")]
		public decimal Open
		{
			get
			{
				return this._Open;
			}
			set
			{
				if ((this._Open != value))
				{
					this.OnOpenChanging(value);
					this.SendPropertyChanging();
					this._Open = value;
					this.SendPropertyChanged("Open");
					this.OnOpenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_High", DbType="Decimal(6,3) NOT NULL")]
		public decimal High
		{
			get
			{
				return this._High;
			}
			set
			{
				if ((this._High != value))
				{
					this.OnHighChanging(value);
					this.SendPropertyChanging();
					this._High = value;
					this.SendPropertyChanged("High");
					this.OnHighChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Low", DbType="Decimal(6,3) NOT NULL")]
		public decimal Low
		{
			get
			{
				return this._Low;
			}
			set
			{
				if ((this._Low != value))
				{
					this.OnLowChanging(value);
					this.SendPropertyChanging();
					this._Low = value;
					this.SendPropertyChanged("Low");
					this.OnLowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last", DbType="Decimal(6,3) NOT NULL")]
		public decimal Last
		{
			get
			{
				return this._Last;
			}
			set
			{
				if ((this._Last != value))
				{
					this.OnLastChanging(value);
					this.SendPropertyChanging();
					this._Last = value;
					this.SendPropertyChanged("Last");
					this.OnLastChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Volume", DbType="Int NOT NULL")]
		public int Volume
		{
			get
			{
				return this._Volume;
			}
			set
			{
				if ((this._Volume != value))
				{
					this.OnVolumeChanging(value);
					this.SendPropertyChanging();
					this._Volume = value;
					this.SendPropertyChanged("Volume");
					this.OnVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_EndOfDay", Storage="_Company", ThisKey="Code", OtherKey="Code", IsForeignKey=true)]
		public Company Company
		{
			get
			{
				return this._Company.Entity;
			}
			set
			{
				Company previousValue = this._Company.Entity;
				if (((previousValue != value) 
							|| (this._Company.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Company.Entity = null;
						previousValue.EndOfDays.Remove(this);
					}
					this._Company.Entity = value;
					if ((value != null))
					{
						value.EndOfDays.Add(this);
						this._Code = value.Code;
					}
					else
					{
						this._Code = default(string);
					}
					this.SendPropertyChanged("Company");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IndustryGroups")]
	public partial class IndustryGroup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Group;
		
		private EntitySet<Company> _Companies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroupChanging(string value);
    partial void OnGroupChanged();
    #endregion
		
		public IndustryGroup()
		{
			this._Companies = new EntitySet<Company>(new Action<Company>(this.attach_Companies), new Action<Company>(this.detach_Companies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Group]", Storage="_Group", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				if ((this._Group != value))
				{
					this.OnGroupChanging(value);
					this.SendPropertyChanging();
					this._Group = value;
					this.SendPropertyChanged("Group");
					this.OnGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IndustryGroup_Company", Storage="_Companies", ThisKey="Group", OtherKey="Group")]
		public EntitySet<Company> Companies
		{
			get
			{
				return this._Companies;
			}
			set
			{
				this._Companies.Assign(value);
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
		
		private void attach_Companies(Company entity)
		{
			this.SendPropertyChanging();
			entity.IndustryGroup = this;
		}
		
		private void detach_Companies(Company entity)
		{
			this.SendPropertyChanging();
			entity.IndustryGroup = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WatchLists")]
	public partial class WatchList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private EntityRef<Company> _Company;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    #endregion
		
		public WatchList()
		{
			this._Company = default(EntityRef<Company>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					if (this._Company.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_WatchList", Storage="_Company", ThisKey="Code", OtherKey="Code", IsForeignKey=true)]
		public Company Company
		{
			get
			{
				return this._Company.Entity;
			}
			set
			{
				Company previousValue = this._Company.Entity;
				if (((previousValue != value) 
							|| (this._Company.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Company.Entity = null;
						previousValue.WatchList = null;
					}
					this._Company.Entity = value;
					if ((value != null))
					{
						value.WatchList = this;
						this._Code = value.Code;
					}
					else
					{
						this._Code = default(string);
					}
					this.SendPropertyChanged("Company");
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
