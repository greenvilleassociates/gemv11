import javax.script.*;

public class JavaScriptInJava {
    public static void main(String[] args) throws ScriptException {
        ScriptEngineManager manager = new ScriptEngineManager();
        ScriptEngine engine = manager.getEngineByName("JavaScript");
        
        // Running JavaScript inside Java
        engine.eval("print('Hello from JavaScript within Java!');");
    }
}

