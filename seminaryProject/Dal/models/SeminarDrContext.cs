using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.models;

public partial class SeminarDrContext : DbContext
{
    public SeminarDrContext()
    {
    }

    public SeminarDrContext(DbContextOptions<SeminarDrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Graduate> Graduates { get; set; }

    public virtual DbSet<HusbandsFather> HusbandsFathers { get; set; }

    public virtual DbSet<Neighborhood> Neighborhoods { get; set; }

    public virtual DbSet<Occupation> Occupations { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PlacesOfBusiness> PlacesOfBusinesses { get; set; }

    public virtual DbSet<Son> Sons { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    public virtual DbSet<Studentship> Studentships { get; set; }

    public virtual DbSet<StudySubject> StudySubjects { get; set; }

    public virtual DbSet<SubjectsOfStudyForTheYear> SubjectsOfStudyForTheYears { get; set; }

    public virtual DbSet<TypesOfFactsInternal> TypesOfFactsInternals { get; set; }

    public virtual DbSet<TypesOfFamily> TypesOfFamilies { get; set; }

    public virtual DbSet<TypesOfOccupation> TypesOfOccupations { get; set; }

    public virtual DbSet<TypesOfOccupation1> TypesOfOccupations1 { get; set; }

    public virtual DbSet<TypesOfStudySubject> TypesOfStudySubjects { get; set; }

    public virtual DbSet<Yearbook> Yearbooks { get; set; }

    public virtual DbSet<YearbookGroupingsPerYear> YearbookGroupingsPerYears { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-E0FAPSB\\SQLEXPRESS;Initial Catalog=SeminarDR; Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3213E83FA42E26ED");

            entity.HasIndex(e => e.Id, "UQ__Cities__3213E83EAE6841AA").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F2260FCDB");

            entity.HasIndex(e => e.Id, "UQ__Employee__3213E83E968F0331").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EducationData)
                .HasColumnType("text")
                .HasColumnName("education_data");
            entity.Property(e => e.EmployeeTypeId).HasColumnName("employee_type_id");

            entity.HasOne(d => d.EmployeeType).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmployeeTypeId)
                .HasConstraintName("FK__Employees__emplo__6A30C649");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Families__3213E83FB2A2BF35");

            entity.HasIndex(e => e.Id, "UQ__Families__3213E83E904C6A3A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FamilyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("family_name");
            entity.Property(e => e.FamilyTypeId).HasColumnName("family_type_id");
            entity.Property(e => e.FatherIdentityPassport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("father_identity_passport");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("home_phone");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.MotherIdentityPassport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mother_identity_passport");
            entity.Property(e => e.Note)
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.StreetId).HasColumnName("street_id");

            entity.HasOne(d => d.FamilyType).WithMany(p => p.Families)
                .HasForeignKey(d => d.FamilyTypeId)
                .HasConstraintName("FK__Families__family__4E88ABD4");

            entity.HasOne(d => d.Street).WithMany(p => p.Families)
                .HasForeignKey(d => d.StreetId)
                .HasConstraintName("FK__Families__street__4D94879B");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gender__3213E83F2A71A520");

            entity.ToTable("Gender");

            entity.HasIndex(e => e.Id, "UQ__Gender__3213E83E0768C941").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Graduate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Graduate__3213E83F8D60B120");

            entity.HasIndex(e => e.Id, "UQ__Graduate__3213E83E55B11C90").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfMarriage)
                .HasColumnType("date")
                .HasColumnName("date_of_marriage");
            entity.Property(e => e.DateStartingWork)
                .HasColumnType("date")
                .HasColumnName("date_starting_work");
            entity.Property(e => e.HusbandFamilyId).HasColumnName("husband_family_id");
            entity.Property(e => e.OccupationId).HasColumnName("occupation_id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Graduates)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Graduates__perso__5FB337D6");
        });

        modelBuilder.Entity<HusbandsFather>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Husbands__3213E83F13EF4C3E");

            entity.ToTable("Husbands_Fathers");

            entity.HasIndex(e => e.Id, "UQ__Husbands__3213E83E33A92C68").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.OccupationId).HasColumnName("occupation_id");
            entity.Property(e => e.OccupationTypeId).HasColumnName("occupation_type_id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.PreviousSessionId).HasColumnName("previous_session_id");

            entity.HasOne(d => d.Person).WithMany(p => p.HusbandsFathers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Husbands___perso__6383C8BA");
        });

        modelBuilder.Entity<Neighborhood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Neighbor__3213E83FA61752B5");

            entity.HasIndex(e => e.Id, "UQ__Neighbor__3213E83E8EFDA3EE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.City).WithMany(p => p.Neighborhoods)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Neighborh__city___3C69FB99");
        });

        modelBuilder.Entity<Occupation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Occupati__3213E83F5112270B");

            entity.HasIndex(e => e.Id, "UQ__Occupati__3213E83E0C75E7F6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OccupationTypeId).HasColumnName("occupation_type_id");

            entity.HasOne(d => d.OccupationType).WithMany(p => p.Occupations)
                .HasForeignKey(d => d.OccupationTypeId)
                .HasConstraintName("FK__Occupatio__occup__6E01572D");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__People__3213E83FDCEBDC9D");

            entity.HasIndex(e => e.Id, "UQ__People__3213E83E5E5E5607").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CellPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cell_phone");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.Details)
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("house_number");
            entity.Property(e => e.IdentityNumberPassport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("identity_number_passport");
            entity.Property(e => e.MaidenName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("maiden_name");
            entity.Property(e => e.MaritalStatusId).HasColumnName("marital_status_id");
            entity.Property(e => e.Photo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.StreetId).HasColumnName("street_id");

            entity.HasOne(d => d.Family).WithMany(p => p.People)
                .HasForeignKey(d => d.FamilyId)
                .HasConstraintName("FK__People__family_i__52593CB8");

            entity.HasOne(d => d.Street).WithMany(p => p.People)
                .HasForeignKey(d => d.StreetId)
                .HasConstraintName("FK__People__street_i__534D60F1");
        });

        modelBuilder.Entity<PlacesOfBusiness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Places_o__3213E83FF6AE1818");

            entity.ToTable("Places_of_Business");

            entity.HasIndex(e => e.Id, "UQ__Places_o__3213E83E45591A56").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BusinessId).HasColumnName("business_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Business).WithMany(p => p.PlacesOfBusinesses)
                .HasForeignKey(d => d.BusinessId)
                .HasConstraintName("FK__Places_of__busin__71D1E811");
        });

        modelBuilder.Entity<Son>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sons__3213E83F68F89402");

            entity.HasIndex(e => e.Id, "UQ__Sons__3213E83E1A6BE1DB").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OccupationTypeId).HasColumnName("occupation_type_id");
            entity.Property(e => e.OriginalResidenceId).HasColumnName("original_residence_id");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.PositionId).HasColumnName("position_id");

            entity.HasOne(d => d.Person).WithMany(p => p.Sons)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Sons__person_id__5BE2A6F2");
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Streets__3213E83F3C4069E2");

            entity.HasIndex(e => e.Id, "UQ__Streets__3213E83EA3A2EEEC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NeighborhoodId).HasColumnName("neighborhood_id");

            entity.HasOne(d => d.Neighborhood).WithMany(p => p.Streets)
                .HasForeignKey(d => d.NeighborhoodId)
                .HasConstraintName("FK__Streets__neighbo__403A8C7D");
        });

        modelBuilder.Entity<Studentship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3213E83F9B40121D");

            entity.ToTable("Studentship");

            entity.HasIndex(e => e.Id, "UQ__Students__3213E83E4B653610").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassNumber).HasColumnName("class_number");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.YearbookId).HasColumnName("yearbook_id");

            entity.HasOne(d => d.Student).WithMany(p => p.Studentships)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Studentsh__stude__571DF1D5");

            entity.HasOne(d => d.Yearbook).WithMany(p => p.Studentships)
                .HasForeignKey(d => d.YearbookId)
                .HasConstraintName("FK__Studentsh__yearb__5812160E");
        });

        modelBuilder.Entity<StudySubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Study_Su__3213E83FD95FC522");

            entity.ToTable("Study_Subjects");

            entity.HasIndex(e => e.Id, "UQ__Study_Su__3213E83EE44E3068").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classification)
                .HasColumnType("text")
                .HasColumnName("classification");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.StudySubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__Study_Sub__subje__7B5B524B");
        });

        modelBuilder.Entity<SubjectsOfStudyForTheYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subjects__3213E83FE91658C8");

            entity.ToTable("Subjects_of_Study_for_the_Year");

            entity.HasIndex(e => e.Id, "UQ__Subjects__3213E83EFD4FC7FF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcademicYear).HasColumnName("academic_year");
            entity.Property(e => e.Groupings)
                .HasColumnType("text")
                .HasColumnName("groupings");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.WeeklyHours).HasColumnName("weekly_hours");
            entity.Property(e => e.YearbookId).HasColumnName("yearbook_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.SubjectsOfStudyForTheYears)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__Subjects___subje__00200768");

            entity.HasOne(d => d.Yearbook).WithMany(p => p.SubjectsOfStudyForTheYears)
                .HasForeignKey(d => d.YearbookId)
                .HasConstraintName("FK__Subjects___yearb__7F2BE32F");
        });

        modelBuilder.Entity<TypesOfFactsInternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types_of__3213E83F232F2232");

            entity.ToTable("Types_of_Facts_Internal");

            entity.HasIndex(e => e.Id, "UQ__Types_of__3213E83E9FB294D3").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypesOfFamily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types_of__3213E83FFC428312");

            entity.ToTable("Types_of_Families");

            entity.HasIndex(e => e.Id, "UQ__Types_of__3213E83E268180C8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypesOfOccupation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types_of__3213E83F8325FB0A");

            entity.ToTable("Types_of_Occupation");

            entity.HasIndex(e => e.Id, "UQ__Types_of__3213E83E2272E905").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypesOfOccupation1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types_of__3213E83F335693E6");

            entity.ToTable("Types_of_Occupations");

            entity.HasIndex(e => e.Id, "UQ__Types_of__3213E83E25FB1223").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OccupationTypeId).HasColumnName("occupation_type_id");
            entity.Property(e => e.ProfessionTypeId).HasColumnName("profession_type_id");

            entity.HasOne(d => d.OccupationType).WithMany(p => p.TypesOfOccupation1s)
                .HasForeignKey(d => d.OccupationTypeId)
                .HasConstraintName("FK__Types_of___occup__46E78A0C");
        });

        modelBuilder.Entity<TypesOfStudySubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types_of__3213E83FB96DD872");

            entity.ToTable("Types_of_Study_Subjects");

            entity.HasIndex(e => e.Id, "UQ__Types_of__3213E83E4421C5D5").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Yearbook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Yearbook__3213E83F446B0BFA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NumClasses).HasColumnName("num_classes");
        });

        modelBuilder.Entity<YearbookGroupingsPerYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Yearbook__3213E83F781C6E43");

            entity.ToTable("Yearbook_Groupings_per_Year");

            entity.HasIndex(e => e.Id, "UQ__Yearbook__3213E83E355D6E24").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CirculationAmount).HasColumnName("circulation_amount");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.YearbookProfessionId).HasColumnName("yearbook_profession_id");

            entity.HasOne(d => d.YearbookProfession).WithMany(p => p.YearbookGroupingsPerYears)
                .HasForeignKey(d => d.YearbookProfessionId)
                .HasConstraintName("FK__Yearbook___yearb__03F0984C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
