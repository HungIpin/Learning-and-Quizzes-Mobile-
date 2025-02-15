﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verification")
                        .HasColumnType("bit");

                    b.HasKey("AccountId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("API.Models.AccountinCourse", b =>
                {
                    b.Property<int>("AccountinCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("GetPayment")
                        .HasColumnType("bit");

                    b.Property<string>("InvoiceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBought")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizCompleted")
                        .HasColumnType("int");

                    b.HasKey("AccountinCourseID");

                    b.HasIndex("AccountId");

                    b.HasIndex("CourseId");

                    b.ToTable("AccountinCourses");
                });

            modelBuilder.Entity("API.Models.AccountinLesson", b =>
                {
                    b.Property<int>("AccountinLessonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AccountId1")
                        .HasColumnType("int");

                    b.Property<string>("ExamQuizCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastTaken")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("QuizName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountinLessonID");

                    b.HasIndex("AccountId1");

                    b.HasIndex("LessonId");

                    b.ToTable("AccountinLessons");
                });

            modelBuilder.Entity("API.Models.Choice", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("AnswerImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("AnswerImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("ChoiceId");

                    b.HasIndex("QuizId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("API.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePost")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.Property<string>("LessonId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId1")
                        .HasColumnType("int");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LessonId1");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("API.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("CourseDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hastag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NumberOfParticipants")
                        .HasColumnType("float");

                    b.Property<double>("NumberOfVoters")
                        .HasColumnType("float");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ThumbnailImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("AccountId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("API.Models.ExamQuiz", b =>
                {
                    b.Property<int>("ExamQuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamIsCorrect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOption1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOption2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOption3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOption4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOption5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ExamOptionImage1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ExamOptionImage2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ExamOptionImage3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ExamOptionImage4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ExamOptionImage5")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ExamOptionImageURL1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOptionImageURL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOptionImageURL3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOptionImageURL4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamOptionImageURL5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamQuestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ExamQuestionImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ExamQuestionImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamQuizCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamQuizName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamTagTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ExamThumbnailImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ExamTime")
                        .HasColumnType("int");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("QuizId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExamQuizId");

                    b.ToTable("ExamQuizs");
                });

            modelBuilder.Entity("API.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LessonContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonNo")
                        .HasColumnType("int");

                    b.Property<string>("LessonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubTopicId")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.HasIndex("SubTopicId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("API.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MessageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SendTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("API.Models.Questionpool", b =>
                {
                    b.Property<int>("QuestionpoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hastag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuestionpoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("QuestionpoolThumbnailImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("QuestionpoolThumbnailImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionpoolId");

                    b.HasIndex("CourseId");

                    b.ToTable("Questionpools");
                });

            modelBuilder.Entity("API.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionpoolId")
                        .HasColumnType("int");

                    b.Property<byte[]>("QuizImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("QuizImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.HasIndex("QuestionpoolId");

                    b.ToTable("Quizs");
                });

            modelBuilder.Entity("API.Models.SubComment", b =>
                {
                    b.Property<int>("SubCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCommentId")
                        .HasColumnType("int");

                    b.Property<string>("SubCommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubDatePost")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubCommentId");

                    b.HasIndex("ParentCommentId");

                    b.HasIndex("UserId");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("API.Models.SubTopic", b =>
                {
                    b.Property<int>("SubTopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubTopicNumber")
                        .HasColumnType("int");

                    b.Property<string>("SubTopicTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("SubTopicId");

                    b.HasIndex("TopicId");

                    b.ToTable("SubTopics");
                });

            modelBuilder.Entity("API.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessionNumber")
                        .HasColumnType("int");

                    b.Property<string>("TopicTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.HasIndex("CourseId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("AvatarPath")
                        .HasColumnType("varbinary(max)");

                    b.Property<float>("Balance")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("API.Models.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.AccountinCourse", b =>
                {
                    b.HasOne("API.Models.Account", "Account")
                        .WithMany("AccountinCourse")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Models.Course", "Course")
                        .WithMany("UserinCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.AccountinLesson", b =>
                {
                    b.HasOne("API.Models.Account", null)
                        .WithMany("AccountinLesson")
                        .HasForeignKey("AccountId1");

                    b.HasOne("API.Models.Lesson", null)
                        .WithMany("UserinLesson")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("API.Models.Choice", b =>
                {
                    b.HasOne("API.Models.Quiz", "Quiz")
                        .WithMany("Choices")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Comment", b =>
                {
                    b.HasOne("API.Models.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Models.Lesson", null)
                        .WithMany("Comments")
                        .HasForeignKey("LessonId1");

                    b.HasOne("API.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Course", b =>
                {
                    b.HasOne("API.Models.Account", "Account")
                        .WithMany("Courses")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Lesson", b =>
                {
                    b.HasOne("API.Models.SubTopic", "SubTopic")
                        .WithMany("Lessons")
                        .HasForeignKey("SubTopicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Questionpool", b =>
                {
                    b.HasOne("API.Models.Course", "Course")
                        .WithMany("Questionpools")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Quiz", b =>
                {
                    b.HasOne("API.Models.Questionpool", "Questionpool")
                        .WithMany("Quizs")
                        .HasForeignKey("QuestionpoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.SubComment", b =>
                {
                    b.HasOne("API.Models.Comment", "ParentComment")
                        .WithMany("SubComments")
                        .HasForeignKey("ParentCommentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API.Models.User", "User")
                        .WithMany("SubComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.SubTopic", b =>
                {
                    b.HasOne("API.Models.Topic", "Topic")
                        .WithMany("SubTopics")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Topic", b =>
                {
                    b.HasOne("API.Models.Course", "Course")
                        .WithMany("Topics")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
