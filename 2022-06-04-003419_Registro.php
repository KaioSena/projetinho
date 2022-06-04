<?php

namespace App\Database\Migrations;

use CodeIgniter\Database\Migration;

class Registro extends Migration
{
    public function up()
    {
        $this->forge->addField(
            [
                'id_reg' =>[
                    'type' => 'INT',
                    'constraint' =>10,
                    'unsigned'       => true,
                 'auto_increment' => true,
                ],
                'nome_reg' =>[
                    'type' => 'VARCHAR',
                    'constraint' =>100,
                    'null' => false,
                ],
                'senha_reg' =>[
                    'type' => 'VARCHAR',
                    'constraint' => 45,
                    'null' => false,
                ],
                'email_reg' =>[
                    'type' => 'VARCHAR',
                    'constraint' => 45,
                    'null' => false,
                ],
                'celular_reg' =>[
                    'type' => 'BIGINT',
                    'constraint' => 11,
                    'null' => false,
                ],
                'id' =>[
                    'type'           => 'INT',
                    'constraint'     => 5,
                    'unsigned'       => true,
                 ],      
            ]
            );
            $attributes = ['ENGINE' => 'InnoDB'];
        $this->forge->addKey('id_reg', true);
        $this->forge->addForeignKey('id','Login','id');
         $this->forge->createTable('Registro',false,$attributes);
    }

    public function down()
    {
       $this->forge->droptable('Registro');
    }
}
