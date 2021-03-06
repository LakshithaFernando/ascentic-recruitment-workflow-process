﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitmentProcessApi.Models;

namespace RecruitmentProcessApi.Migrations
{
    [DbContext(typeof(RecruitmentContext))]
    [Migration("20180805070453_addIsMainWorkFlowProperty")]
    partial class addIsMainWorkFlowProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitmentProcessApi.Models.ApplicantProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicantNo");

                    b.Property<bool>("IsSuccess");

                    b.Property<int>("WorkFlowId");

                    b.HasKey("Id");

                    b.ToTable("applicantProfiles");
                });

            modelBuilder.Entity("RecruitmentProcessApi.Models.WorkflowStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsMainWorkflow");

                    b.Property<int>("OrderNo");

                    b.HasKey("Id");

                    b.ToTable("workFlowSteps");
                });
#pragma warning restore 612, 618
        }
    }
}
