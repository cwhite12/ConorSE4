using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConorSE4

{

    /// <summary>
    /// A user command class that validates whether the user input is valid and only contains alphabet letters or numbers
    /// </summary>
    public class UserCommand : EntityValidator
    {
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public String commandSent { get; set; }

    }
}
