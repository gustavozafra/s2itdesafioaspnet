using S2IT.Desafio.Domain.Entities;
using S2IT.Desafio.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2IT.Desafio.Infra.Data.Repository
{
    public class AmigoRepository : Repository<Amigo>, IAmigoRepository
    {
    }
}
