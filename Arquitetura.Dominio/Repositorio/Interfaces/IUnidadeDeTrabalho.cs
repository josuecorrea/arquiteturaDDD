namespace Arquitetura.Dominio.Repositorio.Interfaces
{
    public interface IUnidadeDeTrabalho
    {
        void AbrirTransacao();

        void FecharTransacao();
    }
}