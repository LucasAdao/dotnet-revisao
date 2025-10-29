using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.models;

internal class Pessoa 
{
    private long _id;
    [Required(ErrorMessage = "O campo Id é obrigatório")]
    public long Id 
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _nome;

    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
    public string Nome 
    {
        get { return _nome; }
        set { _nome = value; }
    }

}

