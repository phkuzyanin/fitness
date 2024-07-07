using System;
namespace Fitness.BL.Model
{
	public class User
	{ 
		public string Name { get; }
		public Gender Gender { get; }
		public DateTime BirthDate { get; }
		public double Weight { get; set; }
		public double Height { get; set; }

		public User(string name,
					Gender gender,
					DateTime birthDate,
					double weight,
					double height)
		{
			#region проверка условий
			if (string.IsNullOrWhiteSpace(name)) {
				throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
			}
			if(gender == null) {
                throw new ArgumentNullException("Пол пользователя не может быть пустым", nameof(gender));
            }
			if (birthDate < DateTime.Parse("01.01.1950") || birthDate>=DateTime.Now) {
				throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
			}
			if(weight <= 0) {
				throw new ArgumentException("Невозможный вес", nameof(weight));
			}
            if (height <= 0) {
				throw new ArgumentException("Невозможный рост", nameof(height));
			}
            #endregion
            Name = name;
			Gender = gender;
			BirthDate = birthDate;
			Weight = weight;
			Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

