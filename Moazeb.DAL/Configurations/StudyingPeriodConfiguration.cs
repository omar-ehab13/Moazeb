using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moazeb.DAL.Constants.Enums;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Moazeb.DAL.Configurations
{
    public class StudyingPeriodConfiguration : IEntityTypeConfiguration<StudyingPeriod>
    {
        public void Configure(EntityTypeBuilder<StudyingPeriod> builder)
        {
            // Get all classes
            List<Class> classes = new List<Class>
            {
                new Class { ClassName = "4A" },
                new Class { ClassName = "4B" },
                new Class { ClassName = "5A" },
                new Class { ClassName = "5B" }
            };

            // Define the subjects available for assignment
            List<SubjectTypes> subjects = new List<SubjectTypes>
            {
                SubjectTypes.ARABIC,
                SubjectTypes.MATH,
                SubjectTypes.ENGLISH,
                SubjectTypes.SCIENCE,
                SubjectTypes.SOCIAL_STUDIES,
                SubjectTypes.COMPUTER,
                SubjectTypes.SKILLS,
                SubjectTypes.SPORTS
            };

            // Iterate over each class
            foreach (var classObj in classes)
            {
                // Iterate over each day
                for (int day = 0; day < 5; day++)
                {
                    // Iterate over each period
                    for (int period = 0; period < 7; period++)
                    {
                        // Generate a random index to select a subject from the list
                        int randomIndex = new Random().Next(subjects.Count);

                        // Get the subject at the random index
                        SubjectTypes selectedSubject = subjects[randomIndex];

                        // Create a new studying period with the selected subject
                        var studyingPeriod = new StudyingPeriod
                        {
                            PeriodCode = $"{((DayOfWeek)day).ToString()}{period+1}_{classObj.ClassName}",
                            PeriodNo = (PeriodNumbers)(period + 1),
                            DayName = (DayOfWeek)day,
                            SubjectCode = $"{selectedSubject.ToString()}_{classObj.ClassName}",
                            ClassName = classObj.ClassName
                        };

                        builder.HasData(studyingPeriod);
                    }
                }
            }
        }
    }
}
