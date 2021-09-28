import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';
import { getTasks, SubmitSolutionCode } from "../serverAPI";

function TasksList(props) {
    const tasks = props.tasks;
    const listItems = tasks.map((task) =>
        <option key={task.name}>
            {task.name}
        </option>
    );
    return (
        <Input type="select" name="select" id="exampleSelect">{listItems}</Input>
    );
}



export class Home extends Component {

    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = { task: [] };
        //this.state = { SubmitCodeStatus: String };
    }

    async componentDidMount() {
        const tasks = await getTasks();
        console.log("tasks component did mount");
        
        this.setState({
            task: tasks
        })

    }
    
    render () {
      return (
        <Form>
            <FormGroup>
                <Label for="exampleEmail">NAME</Label>
                <Input type="text" id="name" placeholder="Name" />
            </FormGroup>
            <FormGroup>
                <Label for="selectTask">SELECT TASK</Label> 
                <TasksList tasks={this.state.task}/> 
            </FormGroup>

            <FormGroup>
                <Label for="exampleEmail">DESCRIPTION</Label>
                <FormText color="muted">
                    This is some placeholder block-level help text for the above input.
                    It's a bit lighter and easily wraps to a new line.
                </FormText>
            </FormGroup>
            <FormGroup>
                <Label for="solutionCode">SOLUTION CODE</Label>
                <Input type="textarea" name="text" id="solutionCode" />
              </FormGroup>
              <FormGroup>
                <Label for="exampleEmail">DESCRIPTION</Label>
                    <Button >Submit</Button>
                </FormGroup>
        </Form>
    );
  }
}
