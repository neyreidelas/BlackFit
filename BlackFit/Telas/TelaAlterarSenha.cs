﻿using BlackFit.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackFit.Telas
{
    public partial class TelaAlterarSenha : Form
    { 
        
        private Funcionario _userLogado;

    //Exigir que a tela tenha o usuário logado
    public TelaAlterarSenha(Funcionario userLogado)
    {
        InitializeComponent();
        _userLogado = userLogado;
    }

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            _userLogado.AlterarSenha(TxtSenhaAtual.Text,
                                     TxtNovaSenha.Text,
                                     TxtConfNovaSenha.Text);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
}
