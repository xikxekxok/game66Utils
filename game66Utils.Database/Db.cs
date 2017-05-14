﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "game66Utils.Database\App.config"
//     Connection String Name: "MyDbContext"
//     Connection String:      "data source=37.140.192.137;initial catalog=u0120612_stock_develop;User ID=u0120612_zeronicus;password=**zapped**;;MultipleActiveResultSets=True;App=EntityFramework"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Web Edition (64-bit)
// Database Engine Edition: Standard

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace game66Utils.Database
{
    using System.Linq;

    #region Unit of work

    public interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<CategoryState> Categories { get; set; } // Category
        System.Data.Entity.DbSet<ProductState> Products { get; set; } // Product
        System.Data.Entity.DbSet<ProductGroupState> ProductGroups { get; set; } // ProductGroup
        System.Data.Entity.DbSet<ProductStockState> ProductStocks { get; set; } // ProductStock
        System.Data.Entity.DbSet<ProductStockEventState> ProductStockEvents { get; set; } // ProductStockEvent
        System.Data.Entity.DbSet<StockState> Stocks { get; set; } // Stock

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class MyDbContext : System.Data.Entity.DbContext, IMyDbContext
    {
        public System.Data.Entity.DbSet<CategoryState> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<ProductState> Products { get; set; } // Product
        public System.Data.Entity.DbSet<ProductGroupState> ProductGroups { get; set; } // ProductGroup
        public System.Data.Entity.DbSet<ProductStockState> ProductStocks { get; set; } // ProductStock
        public System.Data.Entity.DbSet<ProductStockEventState> ProductStockEvents { get; set; } // ProductStockEvent
        public System.Data.Entity.DbSet<StockState> Stocks { get; set; } // Stock

        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=MyDbContext")
        {
        }

        public MyDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryStateConfiguration());
            modelBuilder.Configurations.Add(new ProductStateConfiguration());
            modelBuilder.Configurations.Add(new ProductGroupStateConfiguration());
            modelBuilder.Configurations.Add(new ProductStockStateConfiguration());
            modelBuilder.Configurations.Add(new ProductStockEventStateConfiguration());
            modelBuilder.Configurations.Add(new StockStateConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryStateConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductStateConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductGroupStateConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductStockStateConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductStockEventStateConfiguration(schema));
            modelBuilder.Configurations.Add(new StockStateConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeMyDbContext : IMyDbContext
    {
        public System.Data.Entity.DbSet<CategoryState> Categories { get; set; }
        public System.Data.Entity.DbSet<ProductState> Products { get; set; }
        public System.Data.Entity.DbSet<ProductGroupState> ProductGroups { get; set; }
        public System.Data.Entity.DbSet<ProductStockState> ProductStocks { get; set; }
        public System.Data.Entity.DbSet<ProductStockEventState> ProductStockEvents { get; set; }
        public System.Data.Entity.DbSet<StockState> Stocks { get; set; }

        public FakeMyDbContext()
        {
            Categories = new FakeDbSet<CategoryState>("Id");
            Products = new FakeDbSet<ProductState>("Barcode", "CategoryId");
            ProductGroups = new FakeDbSet<ProductGroupState>("Id");
            ProductStocks = new FakeDbSet<ProductStockState>("BarCode", "CategoryId");
            ProductStockEvents = new FakeDbSet<ProductStockEventState>("Id");
            Stocks = new FakeDbSet<StockState>("CategoryId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TElement>(expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class CategoryState
    {
        public System.Guid Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 256)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) CategoryState pointed by [Stock].[CategoryId] (FK_Stock_Category)
        /// </summary>
        public virtual StockState Stock { get; set; } // Stock.FK_Stock_Category
        /// <summary>
        /// Child Products where [Product].[CategoryId] point to this entity (FK_Product_Category)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProductState> Products { get; set; } // Product.FK_Product_Category

        public CategoryState()
        {
            Products = new System.Collections.Generic.List<ProductState>();
        }
    }

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductState
    {
        public string Barcode { get; set; } // Barcode (Primary key) (length: 32)
        public decimal PurchasePrice { get; set; } // PurchasePrice
        public decimal SellingPrice { get; set; } // SellingPrice
        public System.Guid CategoryId { get; set; } // CategoryId (Primary key)
        public System.Guid ProductGroupId { get; set; } // ProductGroupId

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [Product].([CategoryId]) (FK_Product_Category)
        /// </summary>
        public virtual CategoryState Category { get; set; } // FK_Product_Category
        /// <summary>
        /// Parent ProductGroup pointed by [Product].([ProductGroupId]) (FK_Product_ProductGroup)
        /// </summary>
        public virtual ProductGroupState ProductGroup { get; set; } // FK_Product_ProductGroup
    }

    // ProductGroup
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductGroupState
    {
        public System.Guid Id { get; set; } // Id (Primary key)
        public string Title { get; set; } // Title (length: 512)
        public System.Guid CategoryId { get; set; } // CategoryId

        // Reverse navigation

        /// <summary>
        /// Child Products where [Product].[ProductGroupId] point to this entity (FK_Product_ProductGroup)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProductState> Products { get; set; } // Product.FK_Product_ProductGroup

        public ProductGroupState()
        {
            Products = new System.Collections.Generic.List<ProductState>();
        }
    }

    // ProductStock
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductStockState
    {
        public string BarCode { get; set; } // BarCode (Primary key) (length: 32)
        public System.Guid CategoryId { get; set; } // CategoryId (Primary key)
        public int Quantity { get; set; } // Quantity

        // Foreign keys

        /// <summary>
        /// Parent Stock pointed by [ProductStock].([CategoryId]) (FK_ProductStock_Stock)
        /// </summary>
        public virtual StockState Stock { get; set; } // FK_ProductStock_Stock
    }

    // ProductStockEvent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductStockEventState
    {
        public System.Guid CategoryId { get; set; } // CategoryId
        public System.DateTime DateExecute { get; set; } // DateExecute
        public int ChangeQuantity { get; set; } // ChangeQuantity
        public string BarCode { get; set; } // BarCode (length: 32)
        public System.Guid Id { get; set; } // Id (Primary key)
    }

    // Stock
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class StockState
    {
        public System.Guid CategoryId { get; set; } // CategoryId (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child ProductStocks where [ProductStock].[CategoryId] point to this entity (FK_ProductStock_Stock)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProductStockState> ProductStocks { get; set; } // ProductStock.FK_ProductStock_Stock

        // Foreign keys

        /// <summary>
        /// Parent Category pointed by [Stock].([CategoryId]) (FK_Stock_Category)
        /// </summary>
        public virtual CategoryState Category { get; set; } // FK_Stock_Category

        public StockState()
        {
            ProductStocks = new System.Collections.Generic.List<ProductStockState>();
        }
    }

    #endregion

    #region POCO Configuration

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class CategoryStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CategoryState>
    {
        public CategoryStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public CategoryStateConfiguration(string schema)
        {
            ToTable("Category", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(256);
        }
    }

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductState>
    {
        public ProductStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public ProductStateConfiguration(string schema)
        {
            ToTable("Product", schema);
            HasKey(x => new { x.Barcode, x.CategoryId });

            Property(x => x.Barcode).HasColumnName(@"Barcode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(32).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PurchasePrice).HasColumnName(@"PurchasePrice").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.SellingPrice).HasColumnName(@"SellingPrice").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductGroupId).HasColumnName(@"ProductGroupId").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            HasRequired(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_Product_Category
            HasRequired(a => a.ProductGroup).WithMany(b => b.Products).HasForeignKey(c => c.ProductGroupId).WillCascadeOnDelete(false); // FK_Product_ProductGroup
        }
    }

    // ProductGroup
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductGroupStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductGroupState>
    {
        public ProductGroupStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public ProductGroupStateConfiguration(string schema)
        {
            ToTable("ProductGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsRequired().HasMaxLength(512);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("uniqueidentifier").IsRequired();
        }
    }

    // ProductStock
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductStockStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductStockState>
    {
        public ProductStockStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public ProductStockStateConfiguration(string schema)
        {
            ToTable("ProductStock", schema);
            HasKey(x => new { x.BarCode, x.CategoryId });

            Property(x => x.BarCode).HasColumnName(@"BarCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(32).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Stock).WithMany(b => b.ProductStocks).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false); // FK_ProductStock_Stock
        }
    }

    // ProductStockEvent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class ProductStockEventStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductStockEventState>
    {
        public ProductStockEventStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public ProductStockEventStateConfiguration(string schema)
        {
            ToTable("ProductStockEvent", schema);
            HasKey(x => x.Id);

            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.DateExecute).HasColumnName(@"DateExecute").HasColumnType("datetime").IsRequired();
            Property(x => x.ChangeQuantity).HasColumnName(@"ChangeQuantity").HasColumnType("int").IsRequired();
            Property(x => x.BarCode).HasColumnName(@"BarCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(32);
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

    // Stock
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.29.1.0")]
    public class StockStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StockState>
    {
        public StockStateConfiguration()
            : this("u0120612_zeronicus")
        {
        }

        public StockStateConfiguration(string schema)
        {
            ToTable("Stock", schema);
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Category).WithOptional(b => b.Stock).WillCascadeOnDelete(false); // FK_Stock_Category
        }
    }

    #endregion

}
// </auto-generated>

