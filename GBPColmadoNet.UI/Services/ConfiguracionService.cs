using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GBPColmadoNet.UI.Services
{
    public class ConfiguracionService
    {
        private readonly ColmadoContext _context;

        public ConfiguracionService(ColmadoContext context)
        {
            _context = context;
        }

        public async Task<ConfiguracionesNegocio?> ObtenerConfiguracionAsync()
        {
            return await _context.ConfiguracionesNegocios.FirstOrDefaultAsync();
        }

        public async Task<bool> GuardarConfiguracionAsync(ConfiguracionesNegocio config)
        {
            try
            {
                var existe = await _context.ConfiguracionesNegocios.AnyAsync(c => c.Id == config.Id);
                if (existe)
                {
                    _context.ConfiguracionesNegocios.Update(config);
                }
                else
                {
                    await _context.ConfiguracionesNegocios.AddAsync(config);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
