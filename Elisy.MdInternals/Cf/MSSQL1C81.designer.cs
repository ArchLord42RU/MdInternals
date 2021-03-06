﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elisy.MdInternals.Cf
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GalTUS2")]
	public partial class MSSQL1C81DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConfig(Config instance);
    partial void UpdateConfig(Config instance);
    partial void DeleteConfig(Config instance);
    partial void InsertConfigSave(ConfigSave instance);
    partial void UpdateConfigSave(ConfigSave instance);
    partial void DeleteConfigSave(ConfigSave instance);
    partial void InsertFile(File instance);
    partial void UpdateFile(File instance);
    partial void DeleteFile(File instance);
    partial void InsertParam(Param instance);
    partial void UpdateParam(Param instance);
    partial void DeleteParam(Param instance);
    #endregion
		
		public MSSQL1C81DataContext() :
        base("", mappingSource)
		{
			OnCreated();
		}
		
		public MSSQL1C81DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSSQL1C81DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSSQL1C81DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MSSQL1C81DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<_YearOffset> _YearOffsets
		{
			get
			{
				return this.GetTable<_YearOffset>();
			}
		}
		
		public System.Data.Linq.Table<Config> Configs
		{
			get
			{
				return this.GetTable<Config>();
			}
		}
		
		public System.Data.Linq.Table<ConfigSave> ConfigSaves
		{
			get
			{
				return this.GetTable<ConfigSave>();
			}
		}
		
		public System.Data.Linq.Table<DBSchema> DBSchemas
		{
			get
			{
				return this.GetTable<DBSchema>();
			}
		}
		
		public System.Data.Linq.Table<File> Files
		{
			get
			{
				return this.GetTable<File>();
			}
		}
		
		public System.Data.Linq.Table<Param> Params
		{
			get
			{
				return this.GetTable<Param>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[_YearOffset]")]
	public partial class _YearOffset
	{
		
		private int _Offset;
		
		public _YearOffset()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Offset", DbType="Int NOT NULL")]
		public int Offset
		{
			get
			{
				return this._Offset;
			}
			set
			{
				if ((this._Offset != value))
				{
					this._Offset = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Config")]
	public partial class Config : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FileName;
		
		private System.DateTime _Creation;
		
		private System.DateTime _Modified;
		
		private short _Attributes;
		
		private int _DataSize;
		
		private System.Data.Linq.Binary _BinaryData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnCreationChanging(System.DateTime value);
    partial void OnCreationChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnAttributesChanging(short value);
    partial void OnAttributesChanged();
    partial void OnDataSizeChanging(int value);
    partial void OnDataSizeChanged();
    partial void OnBinaryDataChanging(System.Data.Linq.Binary value);
    partial void OnBinaryDataChanged();
    #endregion
		
		public Config()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creation", DbType="DateTime NOT NULL")]
		public System.DateTime Creation
		{
			get
			{
				return this._Creation;
			}
			set
			{
				if ((this._Creation != value))
				{
					this.OnCreationChanging(value);
					this.SendPropertyChanging();
					this._Creation = value;
					this.SendPropertyChanged("Creation");
					this.OnCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL")]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attributes", DbType="SmallInt NOT NULL")]
		public short Attributes
		{
			get
			{
				return this._Attributes;
			}
			set
			{
				if ((this._Attributes != value))
				{
					this.OnAttributesChanging(value);
					this.SendPropertyChanging();
					this._Attributes = value;
					this.SendPropertyChanged("Attributes");
					this.OnAttributesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataSize", DbType="Int NOT NULL")]
		public int DataSize
		{
			get
			{
				return this._DataSize;
			}
			set
			{
				if ((this._DataSize != value))
				{
					this.OnDataSizeChanging(value);
					this.SendPropertyChanging();
					this._DataSize = value;
					this.SendPropertyChanged("DataSize");
					this.OnDataSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BinaryData", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary BinaryData
		{
			get
			{
				return this._BinaryData;
			}
			set
			{
				if ((this._BinaryData != value))
				{
					this.OnBinaryDataChanging(value);
					this.SendPropertyChanging();
					this._BinaryData = value;
					this.SendPropertyChanged("BinaryData");
					this.OnBinaryDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConfigSave")]
	public partial class ConfigSave : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FileName;
		
		private System.DateTime _Creation;
		
		private System.DateTime _Modified;
		
		private short _Attributes;
		
		private int _DataSize;
		
		private System.Data.Linq.Binary _BinaryData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnCreationChanging(System.DateTime value);
    partial void OnCreationChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnAttributesChanging(short value);
    partial void OnAttributesChanged();
    partial void OnDataSizeChanging(int value);
    partial void OnDataSizeChanged();
    partial void OnBinaryDataChanging(System.Data.Linq.Binary value);
    partial void OnBinaryDataChanged();
    #endregion
		
		public ConfigSave()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creation", DbType="DateTime NOT NULL")]
		public System.DateTime Creation
		{
			get
			{
				return this._Creation;
			}
			set
			{
				if ((this._Creation != value))
				{
					this.OnCreationChanging(value);
					this.SendPropertyChanging();
					this._Creation = value;
					this.SendPropertyChanged("Creation");
					this.OnCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL")]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attributes", DbType="SmallInt NOT NULL")]
		public short Attributes
		{
			get
			{
				return this._Attributes;
			}
			set
			{
				if ((this._Attributes != value))
				{
					this.OnAttributesChanging(value);
					this.SendPropertyChanging();
					this._Attributes = value;
					this.SendPropertyChanged("Attributes");
					this.OnAttributesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataSize", DbType="Int NOT NULL")]
		public int DataSize
		{
			get
			{
				return this._DataSize;
			}
			set
			{
				if ((this._DataSize != value))
				{
					this.OnDataSizeChanging(value);
					this.SendPropertyChanging();
					this._DataSize = value;
					this.SendPropertyChanged("DataSize");
					this.OnDataSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BinaryData", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary BinaryData
		{
			get
			{
				return this._BinaryData;
			}
			set
			{
				if ((this._BinaryData != value))
				{
					this.OnBinaryDataChanging(value);
					this.SendPropertyChanging();
					this._BinaryData = value;
					this.SendPropertyChanged("BinaryData");
					this.OnBinaryDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DBSchema")]
	public partial class DBSchema
	{
		
		private System.Data.Linq.Binary _SerializedData;
		
		public DBSchema()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerializedData", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary SerializedData
		{
			get
			{
				return this._SerializedData;
			}
			set
			{
				if ((this._SerializedData != value))
				{
					this._SerializedData = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Files")]
	public partial class File : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FileName;
		
		private System.DateTime _Creation;
		
		private System.DateTime _Modified;
		
		private short _Attributes;
		
		private int _DataSize;
		
		private System.Data.Linq.Binary _BinaryData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnCreationChanging(System.DateTime value);
    partial void OnCreationChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnAttributesChanging(short value);
    partial void OnAttributesChanged();
    partial void OnDataSizeChanging(int value);
    partial void OnDataSizeChanged();
    partial void OnBinaryDataChanging(System.Data.Linq.Binary value);
    partial void OnBinaryDataChanged();
    #endregion
		
		public File()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creation", DbType="DateTime NOT NULL")]
		public System.DateTime Creation
		{
			get
			{
				return this._Creation;
			}
			set
			{
				if ((this._Creation != value))
				{
					this.OnCreationChanging(value);
					this.SendPropertyChanging();
					this._Creation = value;
					this.SendPropertyChanged("Creation");
					this.OnCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL")]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attributes", DbType="SmallInt NOT NULL")]
		public short Attributes
		{
			get
			{
				return this._Attributes;
			}
			set
			{
				if ((this._Attributes != value))
				{
					this.OnAttributesChanging(value);
					this.SendPropertyChanging();
					this._Attributes = value;
					this.SendPropertyChanged("Attributes");
					this.OnAttributesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataSize", DbType="Int NOT NULL")]
		public int DataSize
		{
			get
			{
				return this._DataSize;
			}
			set
			{
				if ((this._DataSize != value))
				{
					this.OnDataSizeChanging(value);
					this.SendPropertyChanging();
					this._DataSize = value;
					this.SendPropertyChanged("DataSize");
					this.OnDataSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BinaryData", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary BinaryData
		{
			get
			{
				return this._BinaryData;
			}
			set
			{
				if ((this._BinaryData != value))
				{
					this.OnBinaryDataChanging(value);
					this.SendPropertyChanging();
					this._BinaryData = value;
					this.SendPropertyChanged("BinaryData");
					this.OnBinaryDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Params")]
	public partial class Param : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FileName;
		
		private System.DateTime _Creation;
		
		private System.DateTime _Modified;
		
		private short _Attributes;
		
		private int _DataSize;
		
		private System.Data.Linq.Binary _BinaryData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnCreationChanging(System.DateTime value);
    partial void OnCreationChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnAttributesChanging(short value);
    partial void OnAttributesChanged();
    partial void OnDataSizeChanging(int value);
    partial void OnDataSizeChanged();
    partial void OnBinaryDataChanging(System.Data.Linq.Binary value);
    partial void OnBinaryDataChanged();
    #endregion
		
		public Param()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creation", DbType="DateTime NOT NULL")]
		public System.DateTime Creation
		{
			get
			{
				return this._Creation;
			}
			set
			{
				if ((this._Creation != value))
				{
					this.OnCreationChanging(value);
					this.SendPropertyChanging();
					this._Creation = value;
					this.SendPropertyChanged("Creation");
					this.OnCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL")]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attributes", DbType="SmallInt NOT NULL")]
		public short Attributes
		{
			get
			{
				return this._Attributes;
			}
			set
			{
				if ((this._Attributes != value))
				{
					this.OnAttributesChanging(value);
					this.SendPropertyChanging();
					this._Attributes = value;
					this.SendPropertyChanged("Attributes");
					this.OnAttributesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataSize", DbType="Int NOT NULL")]
		public int DataSize
		{
			get
			{
				return this._DataSize;
			}
			set
			{
				if ((this._DataSize != value))
				{
					this.OnDataSizeChanging(value);
					this.SendPropertyChanging();
					this._DataSize = value;
					this.SendPropertyChanged("DataSize");
					this.OnDataSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BinaryData", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary BinaryData
		{
			get
			{
				return this._BinaryData;
			}
			set
			{
				if ((this._BinaryData != value))
				{
					this.OnBinaryDataChanging(value);
					this.SendPropertyChanging();
					this._BinaryData = value;
					this.SendPropertyChanged("BinaryData");
					this.OnBinaryDataChanged();
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
