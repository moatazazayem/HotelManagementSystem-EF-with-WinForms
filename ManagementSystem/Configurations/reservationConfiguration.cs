using ManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Configurations
{
    public class reservationConfiguration : IEntityTypeConfiguration<reservation>
    {
        public void Configure(EntityTypeBuilder<reservation> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd().UseIdentityColumn(1011, 1);
            builder.Property(r => r.first_name).HasMaxLength(50).IsRequired();
            builder.Property(r => r.last_name).HasMaxLength(50).IsRequired();
            builder.Property(r => r.birth_day).HasMaxLength(50).IsRequired();
            builder.Property(r => r.gender).HasMaxLength(50).IsRequired();
            builder.Property(r => r.phone_number).HasMaxLength(50).IsRequired();
            builder.Property(r => r.email_address).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(r => r.street_address).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(r => r.apt_suite).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.city).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(r => r.state).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.zip_code).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.room_type).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.room_floor).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.room_number).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.total_bill).HasColumnType("float").IsRequired();
            builder.Property(r => r.payment_type).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.card_type).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.card_number).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.card_exp).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(r => r.card_cvc).HasColumnType("nchar(10)").IsRequired();
            builder.Property(r => r.arrival_time).HasColumnType("date").IsRequired();
            builder.Property(r => r.leaving_time).HasColumnType("date").IsRequired();
            builder.Property(r => r.check_in).HasColumnType("bit").IsRequired();
            builder.Property(r => r.cleaning).HasColumnType("bit").IsRequired();
            builder.Property(r => r.towel).HasColumnType("bit").IsRequired();
            builder.Property(r => r.s_surprise).HasColumnType("bit").IsRequired();
            builder.Property(r => r.supply_status).HasColumnType("bit").IsRequired();
        }

    }
}
