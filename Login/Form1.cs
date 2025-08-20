namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<User> usuarios = new List<User>();
        bool VerificarUsuario(User user)
        {
            bool nome = false;
            bool senha = false;
            foreach(User usuario in usuarios)
            {
                if (usuario.Username == user.Username)
                {
                    nome = true;
                    if (usuario.Password == user.Password)
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
                if (usuario.Username == user.Username)
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
            lResCadastro.ForeColor = Color.ForestGreen;
            lResCadastro.Text = "Cadastro realizado com sucesso!";
        }
    }
}
