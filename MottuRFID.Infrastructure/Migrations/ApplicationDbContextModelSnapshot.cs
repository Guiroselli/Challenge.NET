﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MottuRFID.Infrastructure.Data;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MottuRFID.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MottuRFID.Domain.Entities.Filial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("CIDADE");

                    b.Property<string>("CodigoFilial")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CODIGO_FILIAL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("NOME");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("PAIS");

                    b.HasKey("Id");

                    b.ToTable("FILIAIS", (string)null);
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.LeituraRFID", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraLeitura")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DATA_HORA_LEITURA");

                    b.Property<int>("MotoId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("MOTO_ID");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<int>("PontoLeituraId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PONTO_LEITURA_ID");

                    b.Property<string>("TagRFID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("TAG_RFID");

                    b.HasKey("Id");

                    b.HasIndex("MotoId");

                    b.HasIndex("PontoLeituraId");

                    b.ToTable("LEITURAS_RFID", (string)null);
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativa")
                        .HasColumnType("BOOLEAN")
                        .HasColumnName("ATIVA");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("COR");

                    b.Property<int>("FilialId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("FILIAL_ID");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("MODELO");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NUMERO_SERIE");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("PLACA");

                    b.Property<int?>("PontoLeituraAtualId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PONTO_LEITURA_ATUAL_ID");

                    b.Property<string>("TagRFID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("TAG_RFID");

                    b.Property<DateTime>("UltimaAtualizacao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ULTIMA_ATUALIZACAO");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.HasIndex("PontoLeituraAtualId");

                    b.ToTable("MOTOS", (string)null);
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.PontoLeitura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("BOOLEAN")
                        .HasColumnName("ATIVO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("FilialId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("FILIAL_ID");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("LOCALIZACAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("NOME");

                    b.Property<double>("PosicaoX")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("POSICAO_X");

                    b.Property<double>("PosicaoY")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("POSICAO_Y");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.ToTable("PONTOS_LEITURA", (string)null);
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.LeituraRFID", b =>
                {
                    b.HasOne("MottuRFID.Domain.Entities.Moto", "Moto")
                        .WithMany("Leituras")
                        .HasForeignKey("MotoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MottuRFID.Domain.Entities.PontoLeitura", "PontoLeitura")
                        .WithMany("Leituras")
                        .HasForeignKey("PontoLeituraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Moto");

                    b.Navigation("PontoLeitura");
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.Moto", b =>
                {
                    b.HasOne("MottuRFID.Domain.Entities.Filial", "Filial")
                        .WithMany("Motos")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MottuRFID.Domain.Entities.PontoLeitura", "PontoLeituraAtual")
                        .WithMany("MotosAtuais")
                        .HasForeignKey("PontoLeituraAtualId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Filial");

                    b.Navigation("PontoLeituraAtual");
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.PontoLeitura", b =>
                {
                    b.HasOne("MottuRFID.Domain.Entities.Filial", "Filial")
                        .WithMany("PontosLeitura")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.Filial", b =>
                {
                    b.Navigation("Motos");

                    b.Navigation("PontosLeitura");
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.Moto", b =>
                {
                    b.Navigation("Leituras");
                });

            modelBuilder.Entity("MottuRFID.Domain.Entities.PontoLeitura", b =>
                {
                    b.Navigation("Leituras");

                    b.Navigation("MotosAtuais");
                });
#pragma warning restore 612, 618
        }
    }
}
