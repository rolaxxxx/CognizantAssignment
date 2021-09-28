import axios from "axios";
import { publicUrl } from "../src/constants"

export const getTasks = async () => {
    try {
        const response = await axios.get(`${publicUrl}task`, {
            headers: {
                'Content-Type': null
            }
        });
        const tasks = response.data;
        console.log(tasks);
        return tasks;
    } catch (errors) {
        console.error(errors);
    }
}

export const SubmitSolutionCode = async () => {
    try {
        const SolutionCode = {
            clientId: 'ceaff7dbd376a9b27d1e8535be67682d',
            clientSecret: '4031b8f8731fa55eb8d7a12b7e8c2141cedd9c731c934c7350d0432f17ef8ded',
            script: 'class HelloWorld {public static void main(String[] args) {System.out.println("Hello, World!")',
            stdin: 'React POST Request Example',
            language: 'Java',
            versionIndex: '0'
        };
        const response = await axios.post('https://api.jdoodle.com/v1/execute', SolutionCode).then(resp => {
            console.log(resp.data);
        });
        const ResponseData = response.data;
        console.log(ResponseData);
        return ResponseData.output;
    } catch (errors) {
        console.error(errors);
    }
}