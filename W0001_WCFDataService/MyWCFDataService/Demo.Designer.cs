﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MyWCFDataService
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class TestEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“TestEntities”部分中的连接字符串初始化新 TestEntities 对象。
        /// </summary>
        public TestEntities() : base("name=TestEntities", "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 TestEntities 对象。
        /// </summary>
        public TestEntities(string connectionString) : base(connectionString, "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 TestEntities 对象。
        /// </summary>
        public TestEntities(EntityConnection connection) : base(connection, "TestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<mr_demo_data> mr_demo_data
        {
            get
            {
                if ((_mr_demo_data == null))
                {
                    _mr_demo_data = base.CreateObjectSet<mr_demo_data>("mr_demo_data");
                }
                return _mr_demo_data;
            }
        }
        private ObjectSet<mr_demo_data> _mr_demo_data;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 mr_demo_data EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTomr_demo_data(mr_demo_data mr_demo_data)
        {
            base.AddObject("mr_demo_data", mr_demo_data);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestModel", Name="mr_demo_data")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class mr_demo_data : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 mr_demo_data 对象。
        /// </summary>
        /// <param name="demo_id">demo_id 属性的初始值。</param>
        /// <param name="city_id">city_id 属性的初始值。</param>
        /// <param name="dept_id">dept_id 属性的初始值。</param>
        public static mr_demo_data Createmr_demo_data(global::System.Int32 demo_id, global::System.Int32 city_id, global::System.Int32 dept_id)
        {
            mr_demo_data mr_demo_data = new mr_demo_data();
            mr_demo_data.demo_id = demo_id;
            mr_demo_data.city_id = city_id;
            mr_demo_data.dept_id = dept_id;
            return mr_demo_data;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 demo_id
        {
            get
            {
                return _demo_id;
            }
            set
            {
                if (_demo_id != value)
                {
                    Ondemo_idChanging(value);
                    ReportPropertyChanging("demo_id");
                    _demo_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("demo_id");
                    Ondemo_idChanged();
                }
            }
        }
        private global::System.Int32 _demo_id;
        partial void Ondemo_idChanging(global::System.Int32 value);
        partial void Ondemo_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 city_id
        {
            get
            {
                return _city_id;
            }
            set
            {
                Oncity_idChanging(value);
                ReportPropertyChanging("city_id");
                _city_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("city_id");
                Oncity_idChanged();
            }
        }
        private global::System.Int32 _city_id;
        partial void Oncity_idChanging(global::System.Int32 value);
        partial void Oncity_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 dept_id
        {
            get
            {
                return _dept_id;
            }
            set
            {
                Ondept_idChanging(value);
                ReportPropertyChanging("dept_id");
                _dept_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dept_id");
                Ondept_idChanged();
            }
        }
        private global::System.Int32 _dept_id;
        partial void Ondept_idChanging(global::System.Int32 value);
        partial void Ondept_idChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String demo_info
        {
            get
            {
                return _demo_info;
            }
            set
            {
                Ondemo_infoChanging(value);
                ReportPropertyChanging("demo_info");
                _demo_info = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("demo_info");
                Ondemo_infoChanged();
            }
        }
        private global::System.String _demo_info;
        partial void Ondemo_infoChanging(global::System.String value);
        partial void Ondemo_infoChanged();

        #endregion
    
    }

    #endregion
    
}