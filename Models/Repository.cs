namespace Projeto.ASPNET.MVC.CRUD_MyTE.Models
{
    public static class Repository
    {
        private static List<Funcionario> _todosOsFuncionarios = new List<Funcionario>();
        public static IEnumerable<Funcionario> TodosOsFuncionarios
        {
            get { return _todosOsFuncionarios; }
        }

        public static void Inserir(Funcionario registroFunc)
        {
            //Criar a instrução
            _todosOsFuncionarios.Add(registroFunc);

        }

        public static void Excluir(Funcionario registroFunc)
        {
            _todosOsFuncionarios.Remove(registroFunc);
        }
    }
}



        
    


