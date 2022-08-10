using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet6.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{ Id=1, Name = "Mizan" },
            new Character{ Id=2, Name = "Asif" },
            new Character{ Id=3, Name = "Ashique" },
            new Character{ Id=4, Name = "Aiman" },
            new Character{ Id=5, Name = "Ahlan" },
            new Character{ Id=6, Name = "Shihan" },
            new Character{ Id=7, Name = "Sumaya" },
            new Character{ Id=8, Name = "Shamima" },
            new Character{ Id=9, Name = "Motin" },
            new Character{ Id=10, Name = "Alim" }
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
             characters.Add(newCharacter);
             serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacter()
        {
            return new ServiceResponse<List<Character>> {Data = characters};
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }
    }
}