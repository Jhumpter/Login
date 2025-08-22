using Login.Infrastructure;

namespace Login
{
    public partial class Form1 : Form
    {
        private List<User> usuarios = new List<User>();
        public Form1()
        {
            InitializeComponent();
            ObterUsuarios();
        }
        private void ObterUsuarios()
        {
            var userRepository = new UserRepository();
            usuarios = userRepository.Get();
        }
        bool VerificarUsuario(User user)
        {
            bool nome = false;
            bool senha = false;
            foreach(User usuario in usuarios)
            {
                if (usuario.username == user.username)
                {
                    nome = true;
                    if (usuario.senha == user.senha)
                    {
                        senha = true;
                    }
                }
            }
            return senha;
        }
        bool UsuarioExiste(User user)
        {
            bool nome = false;
            foreach (User usuario in usuarios)
            {
                if (usuario.username == user.username)
                {
                    nome = true;
                }
            }
            return nome;
        }
        private void bEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBLoginUsuario.Text) || string.IsNullOrWhiteSpace(tBLoginSenha.Text))
            {
                lResLogin.ForeColor = Color.Red;
                lResLogin.Text = "Preencha todos os campos!";
                return;
            }
            User user = new User(tBLoginUsuario.Text, tBLoginSenha.Text);
            if (VerificarUsuario(user))
            {
                lResLogin.ForeColor = Color.ForestGreen;
                lResLogin.Text = "Login realizado com sucesso!";
                return;
            }
            lResLogin.ForeColor = Color.Red;
            lResLogin.Text = "Usuário ou senha incorretos!";
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBCadastroUsuario.Text) || string.IsNullOrWhiteSpace(tBCadastroSenha.Text))
            {
                lResCadastro.ForeColor = Color.Red;
                lResCadastro.Text = "Preencha todos os campos!";
                return;
            }
            User newUser = new User(tBCadastroUsuario.Text, tBCadastroSenha.Text);
            if (UsuarioExiste(newUser))
            {
                lResCadastro.ForeColor = Color.Red;
                lResCadastro.Text = "Usuário já cadastrado!";
                return;
            }
            usuarios.Add(newUser);
            var userRepository = new UserRepository();
            if (!userRepository.Add(newUser))
            {
                lResCadastro.ForeColor = Color.Red;
                lResCadastro.Text = "Erro ao cadastrar usuário!";
                return;
            }
            lResCadastro.ForeColor = Color.ForestGreen;
            lResCadastro.Text = "Cadastro realizado com sucesso!";
        }
    }
}
