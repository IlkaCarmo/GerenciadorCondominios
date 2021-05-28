using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesId);
            builder.Property(m => m.MesId).ValueGeneratedNever();

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nome).IsUnique();

            builder.HasMany(m => m.Alugueis).WithOne(m => m.Mes);
            builder.HasMany(m => m.HistoricoRecursos).WithOne(m => m.Mes);

            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    Nome = "Janeiro"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Fevereiro"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Março"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Abril"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Maio"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Junho"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Julho"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Agosto"
                },

                new Mes
                {
                    MesId = 1,
                    Nome = "Setembro"
                },

                new Mes
                {
                    MesId = 1,
                    Nome = "Outubro"
                },
                new Mes
                {
                    MesId = 1,
                    Nome = "Novembro"
                },

                new Mes
                {
                    MesId = 1,
                    Nome = "Dezembro"
                
                });

            builder.ToTable("Meses");

        }
    }
}
