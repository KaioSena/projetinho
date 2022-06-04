<?php

namespace App\Controllers;

use App\Controllers\BaseController;

class Registro extends BaseController
{
    public function registrar()
    {
        $model = model('RegistrarModel');
        $dados = $this->request->getPost();
        $model = model('Model');
        $dados = $this->request->getPost();

        $model->where('email',$dados['usuario']);
        $resultado = $model->where('senha',$dados['senha'])->find();
        
    }
}
