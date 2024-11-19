using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursovaOOP;

namespace KursovaOOP
{
    public class CrimeRecord : Person, ICriminal
    {
        private string nickname;
        private int? height;
        private string eyeColor;
        private string nationality;
        private DateTime? birthDate;
        private string birthPlace;
        private string lastKnownAddress;
        private string criminalProfession;
        private string hairColor;
        private string distinguishingMarks;

        public string Nickname
        {
            get => nickname;
            set => nickname = value;
        }

        public int? Height
        {
            get => height;
            set => height = value;
        }

        public string EyeColor
        {
            get => eyeColor;
            set => eyeColor = value;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public DateTime? BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        public string BirthPlace
        {
            get => birthPlace;
            set => birthPlace = value;
        }

        public string LastKnownAddress
        {
            get => lastKnownAddress;
            set => lastKnownAddress = value;
        }

        public string CriminalProfession
        {
            get => criminalProfession;
            set => criminalProfession = value;
        }

        public string HairColor
        {
            get => hairColor;
            set => hairColor = value;
        }

        public string DistinguishingMarks
        {
            get => distinguishingMarks;
            set => distinguishingMarks = value;
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} ({Nickname}), Height: {Height}, Eye Color: {EyeColor}, " +
                   $"Nationality: {Nationality}, Birth Date: {BirthDate}, Birth Place: {BirthPlace}, " +
                   $"Last Known Address: {LastKnownAddress}, Profession: {CriminalProfession}, Hair Color: {HairColor}, " +
                   $"Distinguishing Marks: {DistinguishingMarks}";
        }

        public string GetCriminalInfo()
        {
            return GetInfo();
        }

        public bool Matches(CrimeRecord criteria)
        {
            if (criteria == null) return false;

            if (!string.IsNullOrWhiteSpace(criteria.FirstName) && (FirstName == null || !FirstName.Contains(criteria.FirstName))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.LastName) && (LastName == null || !LastName.Contains(criteria.LastName))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.Nickname) && (Nickname == null || !Nickname.Contains(criteria.Nickname))) return false;
            if (criteria.Height.HasValue && Height != criteria.Height) return false;
            if (!string.IsNullOrWhiteSpace(criteria.EyeColor) && (EyeColor == null || !EyeColor.Contains(criteria.EyeColor))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.Nationality) && (Nationality == null || !Nationality.Contains(criteria.Nationality))) return false;
            if (criteria.BirthDate.HasValue && BirthDate != criteria.BirthDate) return false;
            if (!string.IsNullOrWhiteSpace(criteria.BirthPlace) && (BirthPlace == null || !BirthPlace.Contains(criteria.BirthPlace))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.LastKnownAddress) && (LastKnownAddress == null || !LastKnownAddress.Contains(criteria.LastKnownAddress))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.CriminalProfession) && (CriminalProfession == null || !CriminalProfession.Contains(criteria.CriminalProfession))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.HairColor) && (HairColor == null || !HairColor.Contains(criteria.HairColor))) return false;
            if (!string.IsNullOrWhiteSpace(criteria.DistinguishingMarks) && (DistinguishingMarks == null || !DistinguishingMarks.Contains(criteria.DistinguishingMarks))) return false;

            return true;
        }
    }
}