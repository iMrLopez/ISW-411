package com.mlopezitsolutions.eticketvalidator;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class Result_Validation extends AppCompatActivity {

    private TextView ResultTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result__validation);

        //Receive the new intent
        Intent intent = getIntent();
        String result = intent.getStringExtra("ResultadoEscaneo");
        this.SetResult(result);
    }

    private void SetResult(String pId){
        ResultTextView = (TextView) findViewById(R.id.txtv_Result);
        ResultTextView.setText(pId);
    }



}
