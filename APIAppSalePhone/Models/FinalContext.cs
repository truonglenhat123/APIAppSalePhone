using System;
using System.Collections.Generic;
using APIAppSalePhone.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIAppSalePhone.Models;

public partial class FinalContext : DbContext
{
    public FinalContext()
    {
    }

    public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<OderDetail> OderDetails { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Product> Products { get; set; }
    //DESKTOP-O1N1OUG\SQLEXPRESS

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-O1N1OUG\\SQLEXPRESS;Database=final;User Id=sa;Password=123; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK_dbo.Account");

            entity.ToTable("Account");

            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Avatar).HasColumnType("text");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .HasColumnName("create_by");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Requestcode).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK_dbo.Brand");

            entity.ToTable("Brand");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(50)
                .HasColumnName("brand_name");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK_dbo.Contact");

            entity.ToTable("Contact");

            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .HasColumnName("create_by");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasColumnName("status");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.DisscountId).HasName("PK_dbo.Discount");

            entity.ToTable("Discount");

            entity.Property(e => e.DisscountId).HasColumnName("disscount_id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .HasColumnName("create_by");
            entity.Property(e => e.DiscountCode)
                .HasMaxLength(10)
                .HasColumnName("discount_code");
            entity.Property(e => e.DiscountEnd)
                .HasColumnType("datetime")
                .HasColumnName("discount_end");
            entity.Property(e => e.DiscountName)
                .HasMaxLength(100)
                .HasColumnName("discount_name");
            entity.Property(e => e.DiscountPrice).HasColumnName("discount_price");
            entity.Property(e => e.DiscountStar)
                .HasColumnType("datetime")
                .HasColumnName("discount_star");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(50)
                .HasColumnName("employee_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");

            entity.ToTable("Feedback");

            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Feedback_Product");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK_dbo.Genre");

            entity.ToTable("Genre");

            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .HasColumnName("genre_name");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<OderDetail>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.GenreId, e.DisscountId, e.OrderId }).HasName("PK_dbo.Oder_Detail");

            entity.ToTable("Oder_Detail");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.DisscountId).HasColumnName("disscount_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Transection)
                .HasMaxLength(50)
                .HasColumnName("transection");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");

            entity.HasOne(d => d.Genre).WithMany(p => p.OderDetails)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Oder_Detail_Genre");

            entity.HasOne(d => d.Order).WithMany(p => p.OderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Oder_Detail_Order");

            entity.HasOne(d => d.Product).WithMany(p => p.OderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Oder_Detail_Product");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_dbo.Order");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AddressShipping)
                .HasMaxLength(50)
                .HasColumnName("addressShipping");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.OderDate)
                .HasColumnType("datetime")
                .HasColumnName("oder_date");
            entity.Property(e => e.OrderNote)
                .HasMaxLength(200)
                .HasColumnName("order_note");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.PhoneShipping)
                .HasMaxLength(50)
                .HasColumnName("phoneShipping");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");

            entity.HasOne(d => d.Account).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Account");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Customer");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_employee");

            entity.HasOne(d => d.Payment).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("FK_Order_Payment");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_dbo.Payment");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("create_by");
            entity.Property(e => e.PaymentName)
                .HasMaxLength(50)
                .HasColumnName("payment_name");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("update_by");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bonhotrong)
                .HasMaxLength(500)
                .HasColumnName("bonhotrong");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CameraSau)
                .HasMaxLength(500)
                .HasColumnName("cameraSau");
            entity.Property(e => e.CameraTruoc)
                .HasMaxLength(500)
                .HasColumnName("cameraTruoc");
            entity.Property(e => e.Color).HasMaxLength(10);
            entity.Property(e => e.Cpu)
                .HasMaxLength(500)
                .HasColumnName("CPU");
            entity.Property(e => e.CreateAt)
                .HasColumnType("date")
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .HasColumnName("create_by");
            entity.Property(e => e.CreateDate).HasColumnType("date");
            entity.Property(e => e.DisscountId).HasColumnName("disscount_id");
            entity.Property(e => e.DophangiaiManHinh)
                .HasMaxLength(500)
                .HasColumnName("dophangiaiManHinh");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.HeDieuHanh)
                .HasMaxLength(500)
                .HasColumnName("heDieuHanh");
            entity.Property(e => e.Hot).HasColumnName("hot");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .HasColumnName("image");
            entity.Property(e => e.KichThuocManHinh)
                .HasMaxLength(500)
                .HasColumnName("kichThuocManHinh");
            entity.Property(e => e.NewPrice).HasColumnName("New_Price");
            entity.Property(e => e.OldPrice).HasColumnName("Old_Price");
            entity.Property(e => e.Pin)
                .HasMaxLength(500)
                .HasColumnName("pin");
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.Ram)
                .HasMaxLength(500)
                .HasColumnName("ram");
            entity.Property(e => e.Sim)
                .HasMaxLength(500)
                .HasColumnName("sim");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("status");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_dbo.Product_dbo.Brand_brand_id");

            entity.HasOne(d => d.Disscount).WithMany(p => p.Products)
                .HasForeignKey(d => d.DisscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Discount");

            entity.HasOne(d => d.Genre).WithMany(p => p.Products)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Genre");
        });

        base.OnModelCreating(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
