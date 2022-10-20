package com.example.ejemplo1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.provider.ContactsContract;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private TextView miTexto;
    private EditText miEmail;
    private Button miBoton;
    private Button miBotonDer;
    private Button miBotonIzq;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main); //  setContentView conecta la Activity con la vista/layout.
        /*  findViewByID busca en R (registro invisible de Android que contiene todos los elementos de la aplicación)
        *   En este caso relacionamos el objeto creado en código con el que hay en el layout mediante su ID. */
        miTexto = (TextView)findViewById(R.id.txvTitulo);   //  Se realiza un casting porque en un principio tvxTitulo es un objeto genérico T.
        miEmail = (EditText)findViewById(R.id.txeCorreo);
        miBoton = (Button)findViewById(R.id.btnHola);
        miBotonDer = (Button)findViewById(R.id.btnDerecha);
        miBotonIzq = (Button)findViewById(R.id.btnIzquierda);
        /*miBoton.setOnClickListener(new View.OnClickListener() {   //  Esto es si solamente necesitamos un listener para este objeto
            @Override
            public void onClick(View view) {
                miTexto.setText("Botón pulsado");
            }
        });*/
        miBotonDer.setOnClickListener(this);
        miBotonIzq.setOnClickListener(this);
        miBoton.setOnClickListener(this);
        miTexto.setText("Esta es mi primera app");
        miTexto.setTextSize(16);
        miEmail.setText("emaildeejemplo@gmail.com");


    }

    @Override
    public void onClick(View view) {
        switch(view.getId()){
            case R.id.btnDerecha:
                miTexto.setText("Se ha pulsado el botón derecho");
                break;
            case R.id.btnIzquierda:
                miTexto.setText("Se ha pulsado el botón izquierdo");
                break;
            case R.id.btnHola:
                miTexto.setText("Se ha pulsado el botón del medio");
                break;

        }
    }
}