namespace TCT.Core.Modelo.ViewModels
{
    public class OrdenTrabajoViewModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public enum Estado {FINALIZADO, SUSPENDIDO, PROCESO, NO_INICIADO }
    }
}
