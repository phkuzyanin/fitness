﻿using System;
namespace Fitness.BL.Model
{
	public class Gender
	{
		public string Name { get; }
		public Gender(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException("Пол не может быть пустым или null", nameof(name));
			}
			Name = name;
		}
        public override string ToString()
        {
            return Name;
        }
    }
}

