package com.example.primeracalculadora;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    TextView txtNum1;
    TextView txtNum2;
    TextView txtRes;
    Button btnSumar;
    Button btnRestar;
    Button btnMultiplicar;
    Button btnDividir;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtNum1 = (TextView) findViewById(R.id.txtNum1);
        txtNum2 = (TextView) findViewById(R.id.txtNum2);
        txtRes = (TextView) findViewById(R.id.txtResultado);

        btnSumar = (Button) findViewById(R.id.btnSumar);
        btnRestar = (Button) findViewById(R.id.btnResta);
        btnMultiplicar = (Button) findViewById(R.id.btnMultiplicar);
        btnDividir = (Button) findViewById(R.id.btnDividir);
        btnSumar.setOnClickListener(this);
        btnRestar.setOnClickListener(this);
        btnMultiplicar.setOnClickListener(this);
        btnDividir.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        String num1 = (txtNum1.getText()).toString();
        String num2 = (txtNum2.getText()).toString();
        int x = 0;
        int y = 0;
        int res = 0;
        if (num1.length() > 0 && num2.length() > 0) {
            try {
                x = Integer.parseInt(num1);
                y = Integer.parseInt(num2);
            } catch (Exception e) {
                txtNum1.setText("");
                txtNum2.setText("");
                return;
            }
        }
        else{
            return;
        }
        switch (view.getId()) {
            case R.id.btnSumar:
                res = x + y;
                txtRes.setText(String.valueOf(res));

                break;
            case R.id.btnResta:
                res = x - y;
                txtRes.setText(String.valueOf(res));
                break;
            case R.id.btnMultiplicar:
                res = x * y;
                txtRes.setText(String.valueOf(res));
                break;
            case R.id.btnDividir:
                res = x / y;
                txtRes.setText(String.valueOf(res));
                break;
        }
    }
}