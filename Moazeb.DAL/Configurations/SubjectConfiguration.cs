using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Moazeb.DAL.Constants.Enums;
using Moazeb.DAL.Entities;

namespace Moazeb.DAL.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
                // Subjects for grades 1 to 3
                new Subject { SubjectCode = "ARABIC_1A", SubjcetName = SubjectTypes.ARABIC, ClassName = "1A" },
                new Subject { SubjectCode = "MATH_1A", SubjcetName = SubjectTypes.MATH, ClassName = "1A" },
                new Subject { SubjectCode = "ENGLISH_1A", SubjcetName = SubjectTypes.ENGLISH, ClassName = "1A" },
                new Subject { SubjectCode = "SPORTS_1A", SubjcetName = SubjectTypes.SPORTS, ClassName = "1A" },
                new Subject { SubjectCode = "SKILLS_1A", SubjcetName = SubjectTypes.SKILLS, ClassName = "1A" },

                // Repeat the subjects for other classes in grades 1 to 3
                new Subject { SubjectCode = "ARABIC_1B", SubjcetName = SubjectTypes.ARABIC, ClassName = "1B" },
                new Subject { SubjectCode = "MATH_1B", SubjcetName = SubjectTypes.MATH, ClassName = "1B" },
                new Subject { SubjectCode = "ENGLISH_1B", SubjcetName = SubjectTypes.ENGLISH, ClassName = "1B" },
                new Subject { SubjectCode = "SPORTS_1B", SubjcetName = SubjectTypes.SPORTS, ClassName = "1B" },
                new Subject { SubjectCode = "SKILLS_1B", SubjcetName = SubjectTypes.SKILLS, ClassName = "1B" },

                new Subject { SubjectCode = "ARABIC_2A", SubjcetName = SubjectTypes.ARABIC, ClassName = "2A" },
                new Subject { SubjectCode = "MATH_2A", SubjcetName = SubjectTypes.MATH, ClassName = "2A" },
                new Subject { SubjectCode = "ENGLISH_2A", SubjcetName = SubjectTypes.ENGLISH, ClassName = "2A" },
                new Subject { SubjectCode = "SPORTS_2A", SubjcetName = SubjectTypes.SPORTS, ClassName = "2A" },
                new Subject { SubjectCode = "SKILLS_2A", SubjcetName = SubjectTypes.SKILLS, ClassName = "2A" },

                new Subject { SubjectCode = "ARABIC_2B", SubjcetName = SubjectTypes.ARABIC, ClassName = "2B" },
                new Subject { SubjectCode = "MATH_2B", SubjcetName = SubjectTypes.MATH, ClassName = "2B" },
                new Subject { SubjectCode = "ENGLISH_2B", SubjcetName = SubjectTypes.ENGLISH, ClassName = "2B" },
                new Subject { SubjectCode = "SPORTS_2B", SubjcetName = SubjectTypes.SPORTS, ClassName = "2B" },
                new Subject { SubjectCode = "SKILLS_2B", SubjcetName = SubjectTypes.SKILLS, ClassName = "2B" },

                // Subjects for grades 4 to 9
                new Subject { SubjectCode = "ARABIC_4A", SubjcetName = SubjectTypes.ARABIC, ClassName = "4A" },
                new Subject { SubjectCode = "MATH_4A", SubjcetName = SubjectTypes.MATH, ClassName = "4A" },
                new Subject { SubjectCode = "ENGLISH_4A", SubjcetName = SubjectTypes.ENGLISH, ClassName = "4A" },
                new Subject { SubjectCode = "SCIENCE_4A", SubjcetName = SubjectTypes.SCIENCE, ClassName = "4A" },
                new Subject { SubjectCode = "SOCIAL_STUDIES_4A", SubjcetName = SubjectTypes.SOCIAL_STUDIES, ClassName = "4A" },
                new Subject { SubjectCode = "COMPUTER_4A", SubjcetName = SubjectTypes.COMPUTER, ClassName = "4A" },
                new Subject { SubjectCode = "SKILLS_4A", SubjcetName = SubjectTypes.SKILLS, ClassName = "4A" },
                new Subject { SubjectCode = "SPORTS_4A", SubjcetName = SubjectTypes.SPORTS, ClassName = "4A" },

                // Repeat the subjects for other classes in grades 4 to 9
                new Subject { SubjectCode = "ARABIC_4B", SubjcetName = SubjectTypes.ARABIC, ClassName = "4B" },
                new Subject { SubjectCode = "MATH_4B", SubjcetName = SubjectTypes.MATH, ClassName = "4B" },
                new Subject { SubjectCode = "ENGLISH_4B", SubjcetName = SubjectTypes.ENGLISH, ClassName = "4B" },
                new Subject { SubjectCode = "SCIENCE_4B", SubjcetName = SubjectTypes.SCIENCE, ClassName = "4B" },
                new Subject { SubjectCode = "SOCIAL_STUDIES_4B", SubjcetName = SubjectTypes.SOCIAL_STUDIES, ClassName = "4B" },
                new Subject { SubjectCode = "COMPUTER_4B", SubjcetName = SubjectTypes.COMPUTER, ClassName = "4B" },
                new Subject { SubjectCode = "SKILLS_4B", SubjcetName = SubjectTypes.SKILLS, ClassName = "4B" },
                new Subject { SubjectCode = "SPORTS_4B", SubjcetName = SubjectTypes.SPORTS, ClassName = "4B" },

                // Subjects for grade 5A
                new Subject { SubjectCode = "ARABIC_5A", SubjcetName = SubjectTypes.ARABIC, ClassName = "5A" },
                new Subject { SubjectCode = "MATH_5A", SubjcetName = SubjectTypes.MATH, ClassName = "5A" },
                new Subject { SubjectCode = "ENGLISH_5A", SubjcetName = SubjectTypes.ENGLISH, ClassName = "5A" },
                new Subject { SubjectCode = "SCIENCE_5A", SubjcetName = SubjectTypes.SCIENCE, ClassName = "5A" },
                new Subject { SubjectCode = "SOCIAL_STUDIES_5A", SubjcetName = SubjectTypes.SOCIAL_STUDIES, ClassName = "5A" },
                new Subject { SubjectCode = "COMPUTER_5A", SubjcetName = SubjectTypes.COMPUTER, ClassName = "5A" },
                new Subject { SubjectCode = "SKILLS_5A", SubjcetName = SubjectTypes.SKILLS, ClassName = "5A" },
                new Subject { SubjectCode = "SPORTS_5A", SubjcetName = SubjectTypes.SPORTS, ClassName = "5A" },

                // Subjects for grade 5B
                new Subject { SubjectCode = "ARABIC_5B", SubjcetName = SubjectTypes.ARABIC, ClassName = "5B" },
                new Subject { SubjectCode = "MATH_5B", SubjcetName = SubjectTypes.MATH, ClassName = "5B" },
                new Subject { SubjectCode = "ENGLISH_5B", SubjcetName = SubjectTypes.ENGLISH, ClassName = "5B" },
                new Subject { SubjectCode = "SCIENCE_5B", SubjcetName = SubjectTypes.SCIENCE, ClassName = "5B" },
                new Subject { SubjectCode = "SOCIAL_STUDIES_5B", SubjcetName = SubjectTypes.SOCIAL_STUDIES, ClassName = "5B" },
                new Subject { SubjectCode = "COMPUTER_5B", SubjcetName = SubjectTypes.COMPUTER, ClassName = "5B" },
                new Subject { SubjectCode = "SKILLS_5B", SubjcetName = SubjectTypes.SKILLS, ClassName = "5B" },
                new Subject { SubjectCode = "SPORTS_5B", SubjcetName = SubjectTypes.SPORTS, ClassName = "5B" }
            );
        }
    }
}
